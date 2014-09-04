using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Payments.CashOnDelivery.Models
{
    public class ConfigurationModel : BaseDIPSkyModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Plugins.Payment.CashOnDelivery.DescriptionText")]
        public string DescriptionText { get; set; }
        public bool DescriptionText_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payment.CashOnDelivery.AdditionalFee")]
        public decimal AdditionalFee { get; set; }
        public bool AdditionalFee_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payment.CashOnDelivery.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
        public bool AdditionalFeePercentage_OverrideForStore { get; set; }
    }
}