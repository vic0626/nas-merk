﻿using System;
using System.Web.Mvc;
using Nas.Core;
using Nas.Core.Domain.Localization;
using Nas.Core.Domain.Orders;
using Nas.Core.Domain.Tax;
using Nas.Services.Catalog;
using Nas.Services.Customers;
using Nas.Services.Directory;
using Nas.Services.Localization;
using Nas.Services.Messages;
using Nas.Services.Orders;
using Nas.Services.Seo;
using Nas.Web.Framework.Security;
using Nas.Web.Models.Order;

namespace Nas.Web.Controllers
{
    public partial class ReturnRequestController : BaseNasController
    {
		#region Fields

        private readonly IOrderService _orderService;
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;
        private readonly ICurrencyService _currencyService;
        private readonly IPriceFormatter _priceFormatter;
        private readonly IOrderProcessingService _orderProcessingService;
        private readonly ILocalizationService _localizationService;
        private readonly ICustomerService _customerService;
        private readonly IWorkflowMessageService _workflowMessageService;

        private readonly LocalizationSettings _localizationSettings;
        private readonly OrderSettings _orderSettings;

        #endregion

		#region Constructors

        public ReturnRequestController(IOrderService orderService, 
            IWorkContext workContext, IStoreContext storeContext,
            ICurrencyService currencyService, IPriceFormatter priceFormatter,
            IOrderProcessingService orderProcessingService,
            ILocalizationService localizationService,
            ICustomerService customerService,
            IWorkflowMessageService workflowMessageService,
            LocalizationSettings localizationSettings,
            OrderSettings orderSettings)
        {
            this._orderService = orderService;
            this._workContext = workContext;
            this._storeContext = storeContext;
            this._currencyService = currencyService;
            this._priceFormatter = priceFormatter;
            this._orderProcessingService = orderProcessingService;
            this._localizationService = localizationService;
            this._customerService = customerService;
            this._workflowMessageService = workflowMessageService;

            this._localizationSettings = localizationSettings;
            this._orderSettings = orderSettings;
        }

        #endregion

        #region Utilities

        [NonAction]
        protected SubmitReturnRequestModel PrepareReturnRequestModel(SubmitReturnRequestModel model, Order order)
        {
            if (order == null)
                throw new ArgumentNullException("order");

            if (model == null)
                throw new ArgumentNullException("model");

            model.OrderId = order.Id;

            //return reasons
            if (_orderSettings.ReturnRequestReasons != null)
                foreach (var rrr in _orderSettings.ReturnRequestReasons)
                {
                    model.AvailableReturnReasons.Add(new SelectListItem()
                        {
                            Text = rrr,
                            Value = rrr
                        });
                }

            //return actions
            if (_orderSettings.ReturnRequestActions != null)
                foreach (var rra in _orderSettings.ReturnRequestActions)
                {
                    model.AvailableReturnActions.Add(new SelectListItem()
                    {
                        Text = rra,
                        Value = rra
                    });
                }

            //products
            var orderProductVariants = _orderService.GetAllOrderProductVariants(order.Id, null, null, null, null, null, null);
            foreach (var opv in orderProductVariants)
            {
                var opvModel = new SubmitReturnRequestModel.OrderProductVariantModel()
                {
                    Id = opv.Id,
                    ProductId = opv.ProductVariant.ProductId,
                    ProductSeName = opv.ProductVariant.Product.GetSeName(),
                    AttributeInfo = opv.AttributeDescription,
                    Quantity = opv.Quantity
                };

                //product name
                if (!String.IsNullOrEmpty(opv.ProductVariant.GetLocalized(x => x.Name)))
                    opvModel.ProductName = string.Format("{0} ({1})", opv.ProductVariant.Product.GetLocalized(x => x.Name), opv.ProductVariant.GetLocalized(x => x.Name));
                else
                    opvModel.ProductName = opv.ProductVariant.Product.GetLocalized(x => x.Name);
                model.Items.Add(opvModel);

                //unit price
                switch (order.CustomerTaxDisplayType)
                {
                    case TaxDisplayType.ExcludingTax:
                        {
                            var opvUnitPriceExclTaxInCustomerCurrency = _currencyService.ConvertCurrency(opv.UnitPriceExclTax, order.CurrencyRate);
                            opvModel.UnitPrice = _priceFormatter.FormatPrice(opvUnitPriceExclTaxInCustomerCurrency, true, order.CustomerCurrencyCode, _workContext.WorkingLanguage, false);
                        }
                        break;
                    case TaxDisplayType.IncludingTax:
                        {
                            var opvUnitPriceInclTaxInCustomerCurrency = _currencyService.ConvertCurrency(opv.UnitPriceInclTax, order.CurrencyRate);
                            opvModel.UnitPrice = _priceFormatter.FormatPrice(opvUnitPriceInclTaxInCustomerCurrency, true, order.CustomerCurrencyCode, _workContext.WorkingLanguage, true);
                        }
                        break;
                }
            }

            return model;
        }

        #endregion
        
        #region Methods

        [NasHttpsRequirement(SslRequirement.Yes)]
        public ActionResult ReturnRequest(int orderId)
        {
            var order = _orderService.GetOrderById(orderId);
            if (order == null || order.Deleted || _workContext.CurrentCustomer.Id != order.CustomerId)
                return new HttpUnauthorizedResult();

            if (!_orderProcessingService.IsReturnRequestAllowed(order))
                return RedirectToRoute("HomePage");

            var model = new SubmitReturnRequestModel();
            model = PrepareReturnRequestModel(model, order);
            return View(model);
        }

        [HttpPost, ActionName("ReturnRequest")]
        [ValidateInput(false)]
        public ActionResult ReturnRequestSubmit(int orderId, SubmitReturnRequestModel model, FormCollection form)
        {
            var order = _orderService.GetOrderById(orderId);
            if (order == null || order.Deleted || _workContext.CurrentCustomer.Id != order.CustomerId)
                return new HttpUnauthorizedResult();

            if (!_orderProcessingService.IsReturnRequestAllowed(order))
                return RedirectToRoute("HomePage");

            int count = 0;
            foreach (var opv in order.OrderProductVariants)
            {
                int quantity = 0; //parse quantity
                foreach (string formKey in form.AllKeys)
                    if (formKey.Equals(string.Format("quantity{0}", opv.Id), StringComparison.InvariantCultureIgnoreCase))
                    {
                        int.TryParse(form[formKey], out quantity);
                        break;
                    }
                if (quantity > 0)
                {
                    var rr = new ReturnRequest()
                    {
                        StoreId = _storeContext.CurrentStore.Id,
                        OrderProductVariantId = opv.Id,
                        Quantity = quantity,
                        CustomerId = _workContext.CurrentCustomer.Id,
                        ReasonForReturn = model.ReturnReason,
                        RequestedAction = model.ReturnAction,
                        CustomerComments = model.Comments,
                        StaffNotes = string.Empty,
                        ReturnRequestStatus = ReturnRequestStatus.Pending,
                        CreatedOnUtc = DateTime.UtcNow,
                        UpdatedOnUtc = DateTime.UtcNow
                    };
                    _workContext.CurrentCustomer.ReturnRequests.Add(rr);
                    _customerService.UpdateCustomer(_workContext.CurrentCustomer);
                    //notify store owner here (email)
                    _workflowMessageService.SendNewReturnRequestStoreOwnerNotification(rr, opv, _localizationSettings.DefaultAdminLanguageId);

                    count++;
                }
            }

            model = PrepareReturnRequestModel(model, order);
            if (count > 0)
                model.Result = _localizationService.GetResource("ReturnRequests.Submitted");
            else
                model.Result = _localizationService.GetResource("ReturnRequests.NoItemsSubmitted");

            return View(model);
        }

        #endregion
    }
}
