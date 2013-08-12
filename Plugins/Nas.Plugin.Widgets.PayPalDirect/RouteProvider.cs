using System.Web.Mvc;
using System.Web.Routing;
using Nas.Web.Framework.Mvc.Routes;

namespace Nas.Plugin.Payments.PayPalDirect
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            //IPN
            routes.MapRoute("Plugin.Payments.PayPalDirect.IPNHandler",
                 "Plugins/PaymentPayPalDirect/IPNHandler",
                 new { controller = "PaymentPayPalDirect", action = "IPNHandler" },
                 new[] { "Nas.Plugin.Payments.PayPalDirect.Controllers" }
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
