using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Catalog
{
    public partial class CopyProductModel : BaseNasEntityModel
    {

        [NasResourceDisplayName("Admin.Catalog.Products.Copy.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Products.Copy.CopyImages")]
        public bool CopyImages { get; set; }

        [NasResourceDisplayName("Admin.Catalog.Products.Copy.Published")]
        public bool Published { get; set; }

    }
}