
using DIPSky.Core.Configuration;

namespace DIPSky.Plugin.Shipping.AustraliaPost
{
    public class AustraliaPostSettings : ISettings
    {
        public string GatewayUrl { get; set; }

        public decimal AdditionalHandlingCharge { get; set; }
    }
}