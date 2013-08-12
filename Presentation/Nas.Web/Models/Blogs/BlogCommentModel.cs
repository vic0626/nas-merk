using System;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Blogs
{
    public partial class BlogCommentModel : BaseNasEntityModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAvatarUrl { get; set; }

        public string CommentText { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool AllowViewingProfiles { get; set; }
    }
}