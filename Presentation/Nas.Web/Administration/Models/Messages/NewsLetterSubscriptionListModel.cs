using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;
using Telerik.Web.Mvc;

namespace Nas.Admin.Models.Messages
{
    public partial class NewsLetterSubscriptionListModel : BaseNasModel
    {
        public GridModel<NewsLetterSubscriptionModel> NewsLetterSubscriptions { get; set; }

        [NasResourceDisplayName("Admin.Customers.Customers.List.SearchEmail")]
        public string SearchEmail { get; set; }
    }
}