using System.Web.Mvc;
using Nas.Plugin.Shipping.AustraliaPost.Models;
using Nas.Services.Configuration;
using Nas.Web.Framework.Controllers;

namespace Nas.Plugin.Shipping.AustraliaPost.Controllers
{
    [AdminAuthorize]
    public class ShippingAustraliaPostController : Controller
    {
        private readonly AustraliaPostSettings _australiaPostSettings;
        private readonly ISettingService _settingService;

        public ShippingAustraliaPostController(AustraliaPostSettings australiaPostSettings, ISettingService settingService)
        {
            this._australiaPostSettings = australiaPostSettings;
            this._settingService = settingService;
        }

        [ChildActionOnly]
        public ActionResult Configure()
        {
            var model = new AustraliaPostShippingModel();
            model.GatewayUrl = _australiaPostSettings.GatewayUrl;
            model.ShippedFromZipPostalCode = _australiaPostSettings.ShippedFromZipPostalCode;
            model.AdditionalHandlingCharge = _australiaPostSettings.AdditionalHandlingCharge;
            return View("Nas.Plugin.Shipping.AustraliaPost.Views.ShippingAustraliaPost.Configure", model);
        }

        [HttpPost]
        [ChildActionOnly]
        public ActionResult Configure(AustraliaPostShippingModel model)
        {
            if (!ModelState.IsValid)
            {
                return Configure();
            }
            
            //save settings
            _australiaPostSettings.GatewayUrl = model.GatewayUrl;
            _australiaPostSettings.ShippedFromZipPostalCode = model.ShippedFromZipPostalCode;
            _australiaPostSettings.AdditionalHandlingCharge = model.AdditionalHandlingCharge;
            _settingService.SaveSetting(_australiaPostSettings);

            return View("Nas.Plugin.Shipping.AustraliaPost.Views.ShippingAustraliaPost.Configure", model);
        }

    }
}
