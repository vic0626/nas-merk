using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Common
{
    public partial class SystemWarningModel : BaseNasModel
    {
        public SystemWarningLevel Level { get; set; }

        public string Text { get; set; }
    }

    public enum SystemWarningLevel
    {
        Pass,
        Warning,
        Fail
    }
}