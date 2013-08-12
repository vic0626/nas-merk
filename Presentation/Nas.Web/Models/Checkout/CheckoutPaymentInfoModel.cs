using System.Web.Routing;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Checkout
{
    public partial class CheckoutPaymentInfoModel : BaseNasModel
    {
        public string PaymentInfoActionName { get; set; }
        public string PaymentInfoControllerName { get; set; }
        public RouteValueDictionary PaymentInfoRouteValues { get; set; }

        /// <summary>
        /// Used on one-page checkout page
        /// </summary>
        public bool DisplayOrderTotals { get; set; }
    }
}