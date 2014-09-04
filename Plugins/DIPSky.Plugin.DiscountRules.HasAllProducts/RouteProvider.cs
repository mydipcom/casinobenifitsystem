using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Web.Framework.Mvc.Routes;

namespace DIPSky.Plugin.DiscountRules.HasAllProducts
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.DiscountRules.HasAllProducts.Configure",
                 "Plugins/DiscountRulesHasAllProducts/Configure",
                 new { controller = "DiscountRulesHasAllProducts", action = "Configure" },
                 new[] { "DIPSky.Plugin.DiscountRules.HasAllProducts.Controllers" }
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
