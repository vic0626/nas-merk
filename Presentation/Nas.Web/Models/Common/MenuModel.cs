using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Common
{
    public partial class MenuModel : BaseNasModel
    {
        public bool BlogEnabled { get; set; }
        public bool RecentlyAddedProductsEnabled { get; set; }
        public bool ForumEnabled { get; set; }
    }
}