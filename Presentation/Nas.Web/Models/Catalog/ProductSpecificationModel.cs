using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Catalog
{
    public partial class ProductSpecificationModel : BaseNasModel
    {
        public int SpecificationAttributeId { get; set; }

        public string SpecificationAttributeName { get; set; }

        public string SpecificationAttributeOption { get; set; }
    }
}