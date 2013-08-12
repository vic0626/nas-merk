using System.Collections.Generic;
using Nas.Web.Framework.Mvc;
using Nas.Web.Models.Common;

namespace Nas.Web.Models.Customer
{
    public partial class CustomerAddressListModel : BaseNasModel
    {
        public CustomerAddressListModel()
        {
            Addresses = new List<AddressModel>();
        }

        public IList<AddressModel> Addresses { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }
    }
}