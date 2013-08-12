using System.Web.Mvc;
using Nas.Web.Framework;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Common
{
    public partial class UrlRecordModel : BaseNasEntityModel
    {
        [NasResourceDisplayName("Admin.System.SeNames.Name")]
        [AllowHtml]
        public string Name { get; set; }

        [NasResourceDisplayName("Admin.System.SeNames.EntityId")]
        public int EntityId { get; set; }

        [NasResourceDisplayName("Admin.System.SeNames.EntityName")]
        public string EntityName { get; set; }

        [NasResourceDisplayName("Admin.System.SeNames.IsActive")]
        public bool IsActive { get; set; }

        [NasResourceDisplayName("Admin.System.SeNames.Language")]
        public string Language { get; set; }
    }
}