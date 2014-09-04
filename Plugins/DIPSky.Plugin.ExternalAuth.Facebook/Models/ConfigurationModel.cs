using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.ExternalAuth.Facebook.Models
{
    public class ConfigurationModel : BaseDIPSkyModel
    {
        [DipSkyResourceDisplayName("Plugins.ExternalAuth.Facebook.ClientKeyIdentifier")]
        public string ClientKeyIdentifier { get; set; }
        [DipSkyResourceDisplayName("Plugins.ExternalAuth.Facebook.ClientSecret")]
        public string ClientSecret { get; set; }
    }
}