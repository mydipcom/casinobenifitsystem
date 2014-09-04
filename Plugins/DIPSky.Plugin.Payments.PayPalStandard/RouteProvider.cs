using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Web.Framework.Mvc.Routes;

namespace DIPSky.Plugin.Payments.PayPalStandard
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            //PDT
            routes.MapRoute("Plugin.Payments.PayPalStandard.PDTHandler",
                 "Plugins/PaymentPayPalStandard/PDTHandler",
                 new { controller = "PaymentPayPalStandard", action = "PDTHandler" },
                 new[] { "DIPSky.Plugin.Payments.PayPalStandard.Controllers" }
            );
            //IPN
            routes.MapRoute("Plugin.Payments.PayPalStandard.IPNHandler",
                 "Plugins/PaymentPayPalStandard/IPNHandler",
                 new { controller = "PaymentPayPalStandard", action = "IPNHandler" },
                 new[] { "DIPSky.Plugin.Payments.PayPalStandard.Controllers" }
            );
            //Cancel
            routes.MapRoute("Plugin.Payments.PayPalStandard.CancelOrder",
                 "Plugins/PaymentPayPalStandard/CancelOrder",
                 new { controller = "PaymentPayPalStandard", action = "CancelOrder" },
                 new[] { "DIPSky.Plugin.Payments.PayPalStandard.Controllers" }
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
