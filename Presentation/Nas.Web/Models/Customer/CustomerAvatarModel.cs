using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Customer
{
    public partial class CustomerAvatarModel : BaseNasModel
    {
        public string AvatarUrl { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }
    }
}