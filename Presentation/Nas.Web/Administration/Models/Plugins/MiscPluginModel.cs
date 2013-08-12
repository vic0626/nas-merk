using System.Web.Routing;
using Nas.Web.Framework.Mvc;

namespace Nas.Admin.Models.Plugins
{
    public partial class MiscPluginModel : BaseNasModel
    {
        public string FriendlyName { get; set; }

        public string ConfigurationActionName { get; set; }
        public string ConfigurationControllerName { get; set; }
        public RouteValueDictionary ConfigurationRouteValues { get; set; }
    }
}