using System.Web.Mvc;
using DIPSky.Web.Framework.Controllers;

namespace DIPSky.Plugin.Misc.WebServices.Controllers
{
    [AdminAuthorize]
    public class MiscWebServicesController : Controller
    {
        public ActionResult Configure()
        {
            return View("DIPSky.Plugin.Misc.WebServices.Views.MiscWebServices.Configure");
        }
    }
}
