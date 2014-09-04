using System.Web.Mvc;
using System.Web.Routing;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Admin.Models.Shipping
{
    public partial class ShippingRateComputationMethodModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.FriendlyName")]
        [AllowHtml]
        public string FriendlyName { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.SystemName")]
        [AllowHtml]
        public string SystemName { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.IsActive")]
        public bool IsActive { get; set; }

        [DipSkyResourceDisplayName("Admin.Configuration.Shipping.Providers.Fields.Logo")]
        public string LogoUrl { get; set; }
        





        public string ConfigurationActionName { get; set; }
        public string ConfigurationControllerName { get; set; }
        public RouteValueDictionary ConfigurationRouteValues { get; set; }
    }
}