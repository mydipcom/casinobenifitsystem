using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Web.Framework.Mvc.Routes;

namespace DIPSky.Plugin.ExternalAuth.OpenId
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.ExternalAuth.OpenId.Login",
                 "Plugins/ExternalAuthOpenId/Login",
                 new { controller = "ExternalAuthOpenId", action = "Login" },
                 new[] { "DIPSky.Plugin.ExternalAuth.OpenId.Controllers" }
            );
        }
        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
