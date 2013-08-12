using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Checkout
{
    public partial class CheckoutProgressModel : BaseNasModel
    {
        public CheckoutProgressStep CheckoutProgressStep { get; set; }
    }

    public enum CheckoutProgressStep
    {
        Cart,
        Address,
        Shipping,
        Payment,
        Confirm,
        Complete
    }
}