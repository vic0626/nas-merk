using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.Payments.GoogleCheckout.Models
{
    public class ConfigurationModel : BaseNasModel
    {
        [NasResourceDisplayName("Plugins.Payments.GoogleCheckout.Fields.UseSandbox")]
        public bool UseSandbox { get; set; }

        [NasResourceDisplayName("Plugins.Payments.GoogleCheckout.Fields.GoogleVendorId")]
        public string GoogleVendorId { get; set; }

        [NasResourceDisplayName("Plugins.Payments.GoogleCheckout.Fields.GoogleMerchantKey")]
        public string GoogleMerchantKey { get; set; }

        [NasResourceDisplayName("Plugins.Payments.GoogleCheckout.Fields.AuthenticateCallback")]
        public bool AuthenticateCallback { get; set; }

        [NasResourceDisplayName("Plugins.Payments.GoogleCheckout.Fields.PassEditLink")]
        public bool PassEditLink { get; set; }
    }
}