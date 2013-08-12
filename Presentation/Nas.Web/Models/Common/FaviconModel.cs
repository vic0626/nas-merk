using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Common
{
    public partial class FaviconModel : BaseNasModel
    {
        public bool Uploaded { get; set; }
        public string FaviconUrl { get; set; }
    }
}