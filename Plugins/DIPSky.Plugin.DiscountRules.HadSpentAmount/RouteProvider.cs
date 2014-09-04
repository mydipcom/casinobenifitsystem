using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Web.Framework.Mvc.Routes;

namespace DIPSky.Plugin.DiscountRules.HadSpentAmount
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.DiscountRules.HadSpentAmount.Configure",
                 "Plugins/DiscountRulesHadSpentAmount/Configure",
                 new { controller = "DiscountRulesHadSpentAmount", action = "Configure" },
                 new[] { "DIPSky.Plugin.DiscountRules.HadSpentAmount.Controllers" }
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
