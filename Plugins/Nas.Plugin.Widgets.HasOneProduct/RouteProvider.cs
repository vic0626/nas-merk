using System.Web.Mvc;
using System.Web.Routing;
using Nas.Web.Framework.Mvc.Routes;

namespace Nas.Plugin.DiscountRules.HasOneProduct
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.DiscountRules.HasOneProduct.Configure",
                 "Plugins/DiscountRulesHasOneProduct/Configure",
                 new { controller = "DiscountRulesHasOneProduct", action = "Configure" },
                 new[] { "Nas.Plugin.DiscountRules.HasOneProduct.Controllers" }
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
