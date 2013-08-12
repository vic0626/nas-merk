using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Customer
{
    public partial class ForumSubscriptionModel : BaseNasEntityModel
    {
        public int ForumId { get; set; }
        public int ForumTopicId { get; set; }
        public bool TopicSubscription { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
    }
}
