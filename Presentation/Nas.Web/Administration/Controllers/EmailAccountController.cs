﻿using System;
using System.Linq;
using System.Net.Mail;
using System.Web.Mvc;
using Nas.Admin.Models.Messages;
using Nas.Core;
using Nas.Core.Domain.Messages;
using Nas.Services.Configuration;
using Nas.Services.Localization;
using Nas.Services.Messages;
using Nas.Services.Security;
using Nas.Web.Framework.Controllers;
using Telerik.Web.Mvc;

namespace Nas.Admin.Controllers
{
	[AdminAuthorize]
	public partial class EmailAccountController : BaseNasController
	{
        private readonly IEmailAccountService _emailAccountService;
        private readonly ILocalizationService _localizationService;
        private readonly ISettingService _settingService;
        private readonly IEmailSender _emailSender;
        private readonly IStoreContext _storeContext;
        private readonly EmailAccountSettings _emailAccountSettings;
        private readonly IPermissionService _permissionService;

		public EmailAccountController(IEmailAccountService emailAccountService,
            ILocalizationService localizationService, ISettingService settingService,
            IEmailSender emailSender, IStoreContext storeContext,
            EmailAccountSettings emailAccountSettings, IPermissionService permissionService)
		{
            this._emailAccountService = emailAccountService;
            this._localizationService = localizationService;
            this._emailAccountSettings = emailAccountSettings;
            this._emailSender = emailSender;
            this._settingService = settingService;
            this._storeContext = storeContext;
            this._permissionService = permissionService;
		}

		public ActionResult List(string id)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageEmailAccounts))
                return AccessDeniedView();

			//mark as default email account (if selected)
			if (!String.IsNullOrEmpty(id))
			{
				int defaultEmailAccountId = Convert.ToInt32(id);
				var defaultEmailAccount = _emailAccountService.GetEmailAccountById(defaultEmailAccountId);
				if (defaultEmailAccount != null)
				{
					_emailAccountSettings.DefaultEmailAccountId = defaultEmailAccountId;
					_settingService.SaveSetting(_emailAccountSettings);
				}
			}

			var emailAccountModels = _emailAccountService.GetAllEmailAccounts()
									.Select(x => x.ToModel())
									.ToList();
			foreach (var eam in emailAccountModels)
				eam.IsDefaultEmailAccount = eam.Id == _emailAccountSettings.DefaultEmailAccountId;

			var gridModel = new GridModel<EmailAccountModel>
			{
				Data = emailAccountModels,
				Total = emailAccountModels.Count()
			};
			return View(gridModel);
		}

		[HttpPost, GridAction(EnableCustomBinding = true)]
		public ActionResult List(GridCommand command)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageEmailAccounts))
                return AccessDeniedView();

            var emailAccountModels = _emailAccountService.GetAllEmailAccounts()
                                    .Select(x => x.ToModel())
                                    .ToList();
            foreach (var eam in emailAccountModels)
                eam.IsDefaultEmailAccount = eam.Id == _emailAccountSettings.DefaultEmailAccountId;

            var gridModel = new GridModel<EmailAccountModel>
            {
                Data = emailAccountModels,
                Total = emailAccountModels.Count()
            };

			return new JsonResult
			{
				Data = gridModel
			};
		}

		public ActionResult Create()
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageEmailAccounts))
                return AccessDeniedView();

            var model = new EmailAccountModel();
            //default values
            model.Port = 25;
			return View(model);
		}

        [HttpPost, ParameterBasedOnFormNameAttribute("save-continue", "continueEditing")]
		public ActionResult Create(EmailAccountModel model, bool continueEditing)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageEmailAccounts))
                return AccessDeniedView();

            if (ModelState.IsValid)
            {
                var emailAccount = model.ToEntity();
                //set password manually
                emailAccount.Password = model.Password;
                _emailAccountService.InsertEmailAccount(emailAccount);

                SuccessNotification(_localizationService.GetResource("Admin.Configuration.EmailAccounts.Added"));
                return continueEditing ? RedirectToAction("Edit", new { id = emailAccount.Id }) : RedirectToAction("List");
            }

            //If we got this far, something failed, redisplay form
            return View(model);
		}

		public ActionResult Edit(int id)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageEmailAccounts))
                return AccessDeniedView();

			var emailAccount = _emailAccountService.GetEmailAccountById(id);
            if (emailAccount == null)
                //No email account found with the specified id
                return RedirectToAction("List");

			return View(emailAccount.ToModel());
		}

        [HttpPost, ParameterBasedOnFormNameAttribute("save-continue", "continueEditing")]
        [FormValueRequired("save", "save-continue")]
        public ActionResult Edit(EmailAccountModel model, bool continueEditing)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageEmailAccounts))
                return AccessDeniedView();

            var emailAccount = _emailAccountService.GetEmailAccountById(model.Id);
            if (emailAccount == null)
                //No email account found with the specified id
                return RedirectToAction("List");

            if (ModelState.IsValid)
            {
                emailAccount = model.ToEntity(emailAccount);
                _emailAccountService.UpdateEmailAccount(emailAccount);

                SuccessNotification(_localizationService.GetResource("Admin.Configuration.EmailAccounts.Updated"));
                return continueEditing ? RedirectToAction("Edit", new { id = emailAccount.Id }) : RedirectToAction("List");
            }

            //If we got this far, something failed, redisplay form
            return View(model);
		}

        [HttpPost, ActionName("Edit")]
        [FormValueRequired("changepassword")]
        public ActionResult ChangePassword(EmailAccountModel model)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageCustomers))
                return AccessDeniedView();

            var emailAccount = _emailAccountService.GetEmailAccountById(model.Id);
            if (emailAccount == null)
                //No email account found with the specified id
                return RedirectToAction("List");

            //do not validate model
            emailAccount.Password = model.Password;
            _emailAccountService.UpdateEmailAccount(emailAccount);
            SuccessNotification(_localizationService.GetResource("Admin.Configuration.EmailAccounts.Fields.Password.PasswordChanged"));
            return RedirectToAction("Edit", new { id = emailAccount.Id });
        }
        
        [HttpPost, ActionName("Edit")]
        [FormValueRequired("sendtestemail")]
        public ActionResult SendTestEmail(EmailAccountModel model)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageEmailAccounts))
                return AccessDeniedView();

            var emailAccount = _emailAccountService.GetEmailAccountById(model.Id);
            if (emailAccount == null)
                //No email account found with the specified id
                return RedirectToAction("List");

            try
            {
                if (String.IsNullOrWhiteSpace(model.SendTestEmailTo))
                    throw new NasException("Enter test email address");


                var from = new MailAddress(emailAccount.Email, emailAccount.DisplayName);
                var to = new MailAddress(model.SendTestEmailTo);
                string subject = _storeContext.CurrentStore.Name + ". Testing email functionality.";
                string body = "Email works fine.";
                _emailSender.SendEmail(emailAccount, subject, body, from, to);
                SuccessNotification(_localizationService.GetResource("Admin.Configuration.EmailAccounts.SendTestEmail.Success"), false);
            }
            catch (Exception exc)
            {
                ErrorNotification(exc.Message, false);
            }

            //If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageEmailAccounts))
                return AccessDeniedView();

            var emailAccount = _emailAccountService.GetEmailAccountById(id);
            if (emailAccount == null)
                //No email account found with the specified id
                return RedirectToAction("List");

            SuccessNotification(_localizationService.GetResource("Admin.Configuration.EmailAccounts.Deleted"));
            _emailAccountService.DeleteEmailAccount(emailAccount);
            return RedirectToAction("List");
        }
	}
}
