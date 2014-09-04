using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Web.Framework.Mvc.Routes;

namespace DIPSky.Plugin.Shipping.ByWeight
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Shipping.ByWeight.SaveGeneralSettings",
                 "Plugins/ShippingByWeight/SaveGeneralSettings",
                 new { controller = "ShippingByWeight", action = "SaveGeneralSettings", },
                 new[] { "DIPSky.Plugin.Shipping.ByWeight.Controllers" }
            );

            routes.MapRoute("Plugin.Shipping.ByWeight.AddPopup",
                 "Plugins/ShippingByWeight/AddPopup",
                 new { controller = "ShippingByWeight", action = "AddPopup" },
                 new[] { "DIPSky.Plugin.Shipping.ByWeight.Controllers" }
            );
            routes.MapRoute("Plugin.Shipping.ByWeight.EditPopup",
                 "Plugins/ShippingByWeight/EditPopup",
                 new { controller = "ShippingByWeight", action = "EditPopup" },
                 new[] { "DIPSky.Plugin.Shipping.ByWeight.Controllers" }
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
