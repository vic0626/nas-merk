using System.Collections.Generic;
using Nas.Web.Framework.Mvc;
using Nas.Web.Models.Common;

namespace Nas.Web.Models.Checkout
{
    public partial class CheckoutBillingAddressModel : BaseNasModel
    {
        public CheckoutBillingAddressModel()
        {
            ExistingAddresses = new List<AddressModel>();
            NewAddress = new AddressModel();
        }

        public IList<AddressModel> ExistingAddresses { get; set; }

        public AddressModel NewAddress { get; set; }

        /// <summary>
        /// Used on one-page checkout page
        /// </summary>
        public bool NewAddressPreselected { get; set; }
    }
}