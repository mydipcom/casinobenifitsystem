using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Web.Framework.Mvc.Routes;

namespace DIPSky.Plugin.Tax.CountryStateZip
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Plugin.Tax.CountryStateZip.AddTaxRate",
                 "Plugins/TaxCountryStateZip/AddTaxRate",
                 new { controller = "TaxCountryStateZip", action = "AddTaxRate" },
                 new[] { "DIPSky.Plugin.Tax.CountryStateZip.Controllers" }
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
