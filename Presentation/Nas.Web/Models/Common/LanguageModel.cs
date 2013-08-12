using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Common
{
    public partial class LanguageModel : BaseNasEntityModel
    {
        public string Name { get; set; }

        public string FlagImageFileName { get; set; }

    }
}