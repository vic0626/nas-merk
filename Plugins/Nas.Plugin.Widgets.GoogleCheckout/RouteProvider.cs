using System.Web.Mvc;
using System.Web.Routing;
using Nas.Web.Framework.Mvc.Routes;

namespace Nas.Plugin.Payments.GoogleCheckout
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            //Submit Google Checkout button
            routes.MapRoute("Plugin.Payments.GoogleCheckout.SubmitButton",
                 "Plugins/PaymentGoogleCheckout/SubmitButton",
                 new { controller = "PaymentGoogleCheckout", action = "SubmitButton" },
                 new[] { "Nas.Plugin.Payments.GoogleCheckout.Controllers" }
                 );

            //Notification
            routes.MapRoute("Plugin.Payments.GoogleCheckout.NotificationHandler",
                 "Plugins/PaymentGoogleCheckout/NotificationHandler",
                 new { controller = "PaymentGoogleCheckout", action = "NotificationHandler" },
                 new[] { "Nas.Plugin.Payments.GoogleCheckout.Controllers" }
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
