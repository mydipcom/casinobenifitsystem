using System.Web.Routing;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Plugins
{
    public partial class MiscPluginModel : BaseDIPSkyModel
    {
        public string FriendlyName { get; set; }

        public string ConfigurationActionName { get; set; }
        public string ConfigurationControllerName { get; set; }
        public RouteValueDictionary ConfigurationRouteValues { get; set; }
    }
}