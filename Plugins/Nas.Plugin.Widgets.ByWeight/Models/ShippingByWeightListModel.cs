using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Plugin.Shipping.ByWeight.Models
{
    public class ShippingByWeightListModel : BaseNasModel
    {
        [NasResourceDisplayName("Plugins.Shipping.ByWeight.Fields.LimitMethodsToCreated")]
        public bool LimitMethodsToCreated { get; set; }
        
    }
}