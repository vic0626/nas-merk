using Nas.Admin.Models.Common;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Orders
{
    public partial class OrderAddressModel : BaseNasModel
    {
        public int OrderId { get; set; }

        public AddressModel Address { get; set; }
    }
}