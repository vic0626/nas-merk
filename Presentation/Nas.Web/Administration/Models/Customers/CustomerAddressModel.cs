using Nas.Admin.Models.Common;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Customers
{
    public partial class CustomerAddressModel : BaseNasModel
    {
        public int CustomerId { get; set; }

        public AddressModel Address { get; set; }
    }
}