﻿using System.Collections.Generic;
using System.Web.Mvc;
using Nas.Plugin.Payments.PurchaseOrder.Models;
using Nas.Services.Configuration;
using Nas.Services.Payments;
using Nas.Web.Framework.Controllers;

namespace Nas.Plugin.Payments.PurchaseOrder.Controllers
{
    public class PaymentPurchaseOrderController : BaseNasPaymentController
    {
        private readonly ISettingService _settingService;
        private readonly PurchaseOrderPaymentSettings _purchaseOrderPaymentSettings;

        public PaymentPurchaseOrderController(ISettingService settingService, PurchaseOrderPaymentSettings purchaseOrderPaymentSettings)
        {
            this._settingService = settingService;
            this._purchaseOrderPaymentSettings = purchaseOrderPaymentSettings;
        }
        
        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure()
        {
            var model = new ConfigurationModel();
            model.AdditionalFee = _purchaseOrderPaymentSettings.AdditionalFee;
            model.AdditionalFeePercentage = _purchaseOrderPaymentSettings.AdditionalFeePercentage;
            
            return View("Nas.Plugin.Payments.PurchaseOrder.Views.PaymentPurchaseOrder.Configure", model);
        }

        [HttpPost]
        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure(ConfigurationModel model)
        {
            if (!ModelState.IsValid)
                return Configure();
            
            //save settings
            _purchaseOrderPaymentSettings.AdditionalFee = model.AdditionalFee;
            _purchaseOrderPaymentSettings.AdditionalFeePercentage = model.AdditionalFeePercentage;
            _settingService.SaveSetting(_purchaseOrderPaymentSettings);
            
            return View("Nas.Plugin.Payments.PurchaseOrder.Views.PaymentPurchaseOrder.Configure", model);
        }

        [ChildActionOnly]
        public ActionResult PaymentInfo()
        {
            var model = new PaymentInfoModel();
            
            //set postback values
            var form = this.Request.Form;
            model.PurchaseOrderNumber = form["PurchaseOrderNumber"];
            return View("Nas.Plugin.Payments.PurchaseOrder.Views.PaymentPurchaseOrder.PaymentInfo", model);
        }

        [NonAction]
        public override IList<string> ValidatePaymentForm(FormCollection form)
        {
            var warnings = new List<string>();
            return warnings;
        }

        [NonAction]
        public override ProcessPaymentRequest GetPaymentInfo(FormCollection form)
        {
            var paymentInfo = new ProcessPaymentRequest();
            paymentInfo.PurchaseOrderNumber = form["PurchaseOrderNumber"];
            return paymentInfo;
        }
    }
}