using System.Collections.Generic;
using Nas.Web.Framework.Mvc;
using Nas.Web.Models.Common;

namespace Nas.Web.Models.Checkout
{
    public partial class CheckoutShippingAddressModel : BaseNasModel
    {
        public CheckoutShippingAddressModel()
        {
            ExistingAddresses = new List<AddressModel>();
            NewAddress = new AddressModel();
        }

        public IList<AddressModel> ExistingAddresses { get; set; }

        public AddressModel NewAddress { get; set; }

        public bool NewAddressPreselected { get; set; }
    }
}