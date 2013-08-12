using System.Collections.Generic;
using Nas.Web.Models.Common;

namespace Nas.Web.Models.Profile
{
    public partial class ProfilePostsModel
    {
        public IList<PostsModel> Posts { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}