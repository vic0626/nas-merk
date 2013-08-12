using System.Web.Routing;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Cms
{
    public partial class RenderWidgetModel : BaseNasModel
    {
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public RouteValueDictionary RouteValues { get; set; }
    }
}