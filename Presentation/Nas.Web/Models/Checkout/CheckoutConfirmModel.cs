using System.Collections.Generic;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Checkout
{
    public partial class CheckoutConfirmModel : BaseNasModel
    {
        public CheckoutConfirmModel()
        {
            Warnings = new List<string>();
        }

        public string MinOrderTotalWarning { get; set; }

        public IList<string> Warnings { get; set; }
    }
}