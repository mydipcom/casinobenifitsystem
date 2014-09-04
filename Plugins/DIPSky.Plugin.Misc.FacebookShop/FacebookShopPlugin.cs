using System.Web.Routing;
using DIPSky.Core.Plugins;
using DIPSky.Services.Common;

namespace DIPSky.Plugin.Misc.FacebookShop
{
    public class FacebookShopPlugin : BasePlugin, IMiscPlugin
    {
        #region Methods

        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "MiscFacebookShop";
            routeValues = new RouteValueDictionary() { { "Namespaces", "DIPSky.Plugin.Misc.FacebookShop.Controllers" }, { "area", null } };
        }

        #endregion
    }
}
