using System.Web.Mvc;
using System.Web.Routing;
using Nas.Web.Framework.Mvc.Routes;

namespace Nas.Plugin.Shipping.ByWeight
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Shipping.ByWeight.SaveGeneralSettings",
                 "Plugins/ShippingByWeight/SaveGeneralSettings",
                 new { controller = "ShippingByWeight", action = "SaveGeneralSettings", },
                 new[] { "Nas.Plugin.Shipping.ByWeight.Controllers" }
            );

            routes.MapRoute("Plugin.Shipping.ByWeight.AddPopup",
                 "Plugins/ShippingByWeight/AddPopup",
                 new { controller = "ShippingByWeight", action = "AddPopup" },
                 new[] { "Nas.Plugin.Shipping.ByWeight.Controllers" }
            );
            routes.MapRoute("Plugin.Shipping.ByWeight.EditPopup",
                 "Plugins/ShippingByWeight/EditPopup",
                 new { controller = "ShippingByWeight", action = "EditPopup" },
                 new[] { "Nas.Plugin.Shipping.ByWeight.Controllers" }
            );
        }
        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
