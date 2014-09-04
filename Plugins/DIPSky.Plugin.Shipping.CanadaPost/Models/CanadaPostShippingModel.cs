using DIPSky.Web.Framework;

namespace DIPSky.Plugin.Shipping.CanadaPost.Models
{
    public class CanadaPostShippingModel
    {
        [DipSkyResourceDisplayName("Plugins.Shipping.CanadaPost.Fields.Url")]
        public string Url { get; set; }

        [DipSkyResourceDisplayName("Plugins.Shipping.CanadaPost.Fields.Port")]
        public int Port { get; set; }

        [DipSkyResourceDisplayName("Plugins.Shipping.CanadaPost.Fields.CustomerId")]
        public string CustomerId { get; set; }
    }
}