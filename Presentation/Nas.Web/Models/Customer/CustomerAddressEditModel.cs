using Nas.Web.Framework.Mvc;
using Nas.Web.Models.Common;

namespace Nas.Web.Models.Customer
{
    public partial class CustomerAddressEditModel : BaseNasModel
    {
        public CustomerAddressEditModel()
        {
            this.Address = new AddressModel();
        }
        public AddressModel Address { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }
    }
}