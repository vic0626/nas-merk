using System.Web.Routing;
using Nas.Web.Framework.Mvc;

namespace Nas.Web.Models.Customer
{
    public partial class ExternalAuthenticationMethodModel : BaseNasModel
    {
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public RouteValueDictionary RouteValues { get; set; }
    }
}