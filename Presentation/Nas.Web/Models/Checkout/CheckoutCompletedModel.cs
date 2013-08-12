using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Checkout
{
    public partial class CheckoutCompletedModel : BaseNasModel
    {
        public int OrderId { get; set; }
        public bool OnePageCheckoutEnabled { get; set; }
    }
}