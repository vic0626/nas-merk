using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Customer
{
    public partial class BackInStockSubscriptionModel : BaseNasEntityModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string SeName { get; set; }
    }
}
