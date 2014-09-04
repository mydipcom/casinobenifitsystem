using System.Web.Mvc;

namespace DIPSky.Web.Controllers
{
    public partial class KeepAliveController : Controller
    {
        public ActionResult Index()
        {
            return Content("I am alive!");
        }
    }
}
