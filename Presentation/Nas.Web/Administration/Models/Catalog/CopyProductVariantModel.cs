using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Catalog
{
    public partial class CopyProductVariantModel : BaseNasEntityModel
    {
        [NasResourceDisplayName("Admin.Catalog.Products.Variants.Copy.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Products.Variants.Copy.Published")]
        public bool Published { get; set; }

    }
}