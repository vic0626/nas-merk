using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Catalog
{
    public partial class ProductSpecificationAttributeModel : BaseNasEntityModel
    {
        [NasResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttribute")]
        [AllowHtml]
        public string SpecificationAttributeName { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttributeOption")]
        [AllowHtml]
        public string SpecificationAttributeOptionName { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.CustomValue")]
        [AllowHtml]
        public string CustomValue { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AllowFiltering")]
        public bool AllowFiltering { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.ShowOnProductPage")]
        public bool ShowOnProductPage { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}