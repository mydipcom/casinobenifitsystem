using DIPSky.Web.Framework;

namespace DIPSky.Plugin.Shipping.AustraliaPost.Models
{
    public class AustraliaPostShippingModel
    {
        [DipSkyResourceDisplayName("Plugins.Shipping.AustraliaPost.Fields.GatewayUrl")]
        public string GatewayUrl { get; set; }

        [DipSkyResourceDisplayName("Plugins.Shipping.AustraliaPost.Fields.AdditionalHandlingCharge")]
        public decimal AdditionalHandlingCharge { get; set; }
    }
}