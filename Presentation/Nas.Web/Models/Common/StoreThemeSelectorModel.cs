using System.Collections.Generic;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Common
{
    public partial class StoreThemeSelectorModel : BaseNasModel
    {
        public StoreThemeSelectorModel()
        {
            AvailableStoreThemes = new List<StoreThemeModel>();
        }

        public IList<StoreThemeModel> AvailableStoreThemes { get; set; }

        public StoreThemeModel CurrentStoreTheme { get; set; }
    }
}