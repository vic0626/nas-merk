using System.Collections.Generic;
using System.Web.Mvc;
using Nas.Plugin.Payments.CashOnDelivery.Models;
using Nas.Services.Configuration;
using Nas.Services.Payments;
using Nas.Web.Framework.Controllers;

namespace Nas.Plugin.Payments.CashOnDelivery.Controllers
{
    public class PaymentCashOnDeliveryController : BaseNasPaymentController
    {
        private readonly ISettingService _settingService;
        private readonly CashOnDeliveryPaymentSettings _cashOnDeliveryPaymentSettings;

        public PaymentCashOnDeliveryController(ISettingService settingService, CashOnDeliveryPaymentSettings cashOnDeliveryPaymentSettings)
        {
            this._settingService = settingService;
            this._cashOnDeliveryPaymentSettings = cashOnDeliveryPaymentSettings;
        }
        
        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure()
        {
            var model = new ConfigurationModel();
            model.DescriptionText = _cashOnDeliveryPaymentSettings.DescriptionText;
            model.AdditionalFee = _cashOnDeliveryPaymentSettings.AdditionalFee;
            model.AdditionalFeePercentage = _cashOnDeliveryPaymentSettings.AdditionalFeePercentage;
            
            return View("Nas.Plugin.Payments.CashOnDelivery.Views.PaymentCashOnDelivery.Configure", model);
        }

        [HttpPost]
        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure(ConfigurationModel model)
        {
            if (!ModelState.IsValid)
                return Configure();
            
            //save settings
            _cashOnDeliveryPaymentSettings.DescriptionText = model.DescriptionText;
            _cashOnDeliveryPaymentSettings.AdditionalFee = model.AdditionalFee;
            _cashOnDeliveryPaymentSettings.AdditionalFeePercentage = model.AdditionalFeePercentage;
            _settingService.SaveSetting(_cashOnDeliveryPaymentSettings);
            
            return View("Nas.Plugin.Payments.CashOnDelivery.Views.PaymentCashOnDelivery.Configure", model);
        }

        [ChildActionOnly]
        public ActionResult PaymentInfo()
        {
            var model = new PaymentInfoModel()
            {
                DescriptionText = _cashOnDeliveryPaymentSettings.DescriptionText
            };

            return View("Nas.Plugin.Payments.CashOnDelivery.Views.PaymentCashOnDelivery.PaymentInfo", model);
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
            return paymentInfo;
        }
    }
}