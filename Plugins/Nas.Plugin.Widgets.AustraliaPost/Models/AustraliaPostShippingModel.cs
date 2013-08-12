using System.ComponentModel;
using Nas.Web.Framework;

namespace Nas.Plugin.Shipping.AustraliaPost.Models
{
    public class AustraliaPostShippingModel
    {
        [NasResourceDisplayName("Plugins.Shipping.AustraliaPost.Fields.GatewayUrl")]
        public string GatewayUrl { get; set; }

        [DisplayName("Additional handling charge")]
        [NasResourceDisplayName("Plugins.Shipping.AustraliaPost.Fields.AdditionalHandlingCharge")]
        public decimal AdditionalHandlingCharge { get; set; }

        [DisplayNameAttribute("Shipped from zip")]
        [NasResourceDisplayName("Plugins.Shipping.AustraliaPost.Fields.ShippedFromZipPostalCode")]
        public string ShippedFromZipPostalCode { get; set; }
    }
}