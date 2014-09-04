using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Web.Framework.Mvc.Routes;

namespace DIPSky.Plugin.DiscountRules.CustomerRoles
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.DiscountRules.CustomerRoles.Configure",
                 "Plugins/DiscountRulesCustomerRoles/Configure",
                 new { controller = "DiscountRulesCustomerRoles", action = "Configure" },
                 new[] { "DIPSky.Plugin.DiscountRules.CustomerRoles.Controllers" }
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
