using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Checkout
{
    public partial class OnePageCheckoutModel : BaseNasModel
    {
        public bool ShippingRequired { get; set; }
    }
}