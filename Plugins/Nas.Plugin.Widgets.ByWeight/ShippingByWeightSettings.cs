
using Nas.Core.Configuration;

namespace Nas.Plugin.Shipping.ByWeight
{
    public class ShippingByWeightSettings : ISettings
    {
        public bool LimitMethodsToCreated { get; set; }
    }
}