using System.Collections.Generic;
using Nas.Web.Framework.Mvc;
using Nas.Web.Models.Catalog;
using Nas.Web.Models.Topics;

namespace Nas.Web.Models.Common
{
    public partial class SitemapModel : BaseNasModel
    {
        public SitemapModel()
        {
            Products = new List<ProductOverviewModel>();
            Categories = new List<CategoryModel>();
            Manufacturers = new List<ManufacturerModel>();
            Topics = new List<TopicModel>();
        }
        public IList<ProductOverviewModel> Products { get; set; }
        public IList<CategoryModel> Categories { get; set; }
        public IList<ManufacturerModel> Manufacturers { get; set; }
        public IList<TopicModel> Topics { get; set; }
    }
}