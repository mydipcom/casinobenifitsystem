using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.ExternalAuthentication
{
    public partial class AuthenticationMethodModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.FriendlyName")]
        [AllowHtml]
        public string FriendlyName { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.SystemName")]
        [AllowHtml]
        public string SystemName { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.IsActive")]
        public bool IsActive { get; set; }



        public string ConfigurationActionName { get; set; }
        public string ConfigurationControllerName { get; set; }
        public RouteValueDictionary ConfigurationRouteValues { get; set; }
    }
}