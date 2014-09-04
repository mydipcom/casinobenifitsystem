
using DIPSky.Core.Configuration;

namespace DIPSky.Plugin.Shipping.ByWeight
{
    public class ShippingByWeightSettings : ISettings
    {
        public bool LimitMethodsToCreated { get; set; }
    }
}