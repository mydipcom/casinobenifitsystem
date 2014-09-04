using DIPSky.Web.Framework;

namespace DIPSky.Plugin.Shipping.FixedRateShipping.Models
{
    public class FixedShippingRateModel
    {
        public int ShippingMethodId { get; set; }

        [DipSkyResourceDisplayName("Plugins.Shipping.FixedRateShipping.Fields.ShippingMethodName")]
        public string ShippingMethodName { get; set; }

        [DipSkyResourceDisplayName("Plugins.Shipping.FixedRateShipping.Fields.Rate")]
        public decimal Rate { get; set; }
    }
}