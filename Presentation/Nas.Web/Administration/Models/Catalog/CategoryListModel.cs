using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;
using Telerik.Web.Mvc;

namespace Nas.Admin.Models.Catalog
{
    public partial class CategoryListModel : BaseNasModel
    {
        [NasResourceDisplayName("Admin.Catalog.Categories.List.SearchCategoryName")]
        [AllowHtml]
        public string SearchCategoryName { get; set; }

        public GridModel<CategoryModel> Categories { get; set; }
    }
}