using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;
using Telerik.Web.Mvc;

namespace Nas.Admin.Models.Catalog
{
    public partial class ManufacturerListModel : BaseNasModel
    {
        [NasResourceDisplayName("Admin.Catalog.Manufacturers.List.SearchManufacturerName")]
        [AllowHtml]
        public string SearchManufacturerName { get; set; }

        public GridModel<ManufacturerModel> Manufacturers { get; set; }
    }
}