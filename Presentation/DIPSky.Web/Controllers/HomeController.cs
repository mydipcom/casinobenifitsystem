using System.Web.Mvc;
using DIPSky.Web.Framework.Security;

namespace DIPSky.Web.Controllers
{
    public partial class HomeController : BaseDIPSkyController
    {
        [DipSkyHttpsRequirement(SslRequirement.No)]
        public ActionResult Index()
        {
            return View();
        }
    }
}
