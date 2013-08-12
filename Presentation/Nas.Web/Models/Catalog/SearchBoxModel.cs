using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Catalog
{
    public partial class SearchBoxModel : BaseNasModel
    {
        public bool AutoCompleteEnabled { get; set; }
        public bool ShowProductImagesInSearchAutoComplete { get; set; }
        public int SearchTermMinimumLength { get; set; }
    }
}