using Nas.Web.Framework;

namespace Nas.Plugin.Shipping.FixedRateShipping.Models
{
    public class FixedShippingRateModel
    {
        public int ShippingMethodId { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.FixedRateShipping.Fields.ShippingMethodName")]
        public string ShippingMethodName { get; set; }

        [NasResourceDisplayName("Plugins.Shipping.FixedRateShipping.Fields.Rate")]
        public decimal Rate { get; set; }
    }
}