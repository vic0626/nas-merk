using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Blogs
{
    public partial class BlogPostTagModel : BaseNasModel
    {
        public string Name { get; set; }

        public int BlogPostCount { get; set; }
    }
}