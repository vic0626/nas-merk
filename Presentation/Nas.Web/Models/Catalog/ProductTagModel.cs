using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Catalog
{
    public partial class ProductTagModel : BaseNasEntityModel
    {
        public string Name { get; set; }

        public string SeName { get; set; }

        public int ProductCount { get; set; }
    }
}