using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Home
{
    public partial class DashboardModel : BaseNasModel
    {
        public bool IsLoggedInAsVendor { get; set; }
    }
}