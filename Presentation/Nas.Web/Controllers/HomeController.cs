using System.Web.Mvc;
using Nas.Web.Framework.Security;

namespace Nas.Web.Controllers
{
    public partial class HomeController : BaseNasController
    {
        [NasHttpsRequirement(SslRequirement.No)]
        public ActionResult Index()
        {
            return View();
        }
    }
}
