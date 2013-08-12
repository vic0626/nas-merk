using System.Collections.Generic;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Blogs
{
    public partial class BlogPostYearModel : BaseNasModel
    {
        public BlogPostYearModel()
        {
            Months = new List<BlogPostMonthModel>();
        }
        public int Year { get; set; }
        public IList<BlogPostMonthModel> Months { get; set; }
    }
    public partial class BlogPostMonthModel : BaseNasModel
    {
        public int Month { get; set; }

        public int BlogPostCount { get; set; }
    }
}