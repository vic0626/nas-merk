using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Common
{
    public partial class AdminHeaderLinksModel : BaseNasModel
    {
        public string ImpersonatedCustomerEmailUsername { get; set; }
        public bool IsCustomerImpersonated { get; set; }
        public bool DisplayAdminLink { get; set; }
    }
}