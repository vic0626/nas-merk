using System.Web.Mvc;
using Nas.Web.Framework.Controllers;

namespace Nas.Plugin.Misc.WebServices.Controllers
{
    [AdminAuthorize]
    public class MiscWebServicesController : Controller
    {
        public ActionResult Configure()
        {
            return View("Nas.Plugin.Misc.WebServices.Views.MiscWebServices.Configure");
        }
    }
}
