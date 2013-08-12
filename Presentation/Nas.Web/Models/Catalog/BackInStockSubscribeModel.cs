using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Catalog
{
    public partial class BackInStockSubscribeModel : BaseNasModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSeName { get; set; }

        public int ProductVariantId { get; set; }
        public bool IsCurrentCustomerRegistered { get; set; }
        public bool SubscriptionAllowed { get; set; }
        public bool AlreadySubscribed { get; set; }

        public int MaximumBackInStockSubscriptions { get; set; }
        public int CurrentNumberOfBackInStockSubscriptions { get; set; }
    }
}