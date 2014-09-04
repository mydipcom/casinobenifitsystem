using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Payments.PurchaseOrder.Models
{
    public class ConfigurationModel : BaseDIPSkyModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payment.PurchaseOrder.AdditionalFee")]
        public decimal AdditionalFee { get; set; }
        public bool AdditionalFee_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payment.PurchaseOrder.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
        public bool AdditionalFeePercentage_OverrideForStore { get; set; }
    }
}