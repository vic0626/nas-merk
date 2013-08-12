using System.Web.Mvc;
using System.Web.Routing;
using Nas.Web.Framework.Mvc.Routes;

namespace Nas.Plugin.DiscountRules.CustomerRoles
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.DiscountRules.CustomerRoles.Configure",
                 "Plugins/DiscountRulesCustomerRoles/Configure",
                 new { controller = "DiscountRulesCustomerRoles", action = "Configure" },
                 new[] { "Nas.Plugin.DiscountRules.CustomerRoles.Controllers" }
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
