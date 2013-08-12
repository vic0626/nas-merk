using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Security
{
    public partial class PermissionRecordModel : BaseNasModel
    {
        public string Name { get; set; }
        public string SystemName { get; set; }
    }
}