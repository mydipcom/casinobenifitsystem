using System.Web.Mvc;
using DIPSky.Web.Framework;
using DIPSky.Web.Framework.Mvc;

namespace DIPSky.Plugin.Payments.CheckMoneyOrder.Models
{
    public class ConfigurationModel : BaseDIPSkyModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [AllowHtml]
        [DipSkyResourceDisplayName("Plugins.Payment.CheckMoneyOrder.DescriptionText")]
        public string DescriptionText { get; set; }
        public bool DescriptionText_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payment.CheckMoneyOrder.AdditionalFee")]
        public decimal AdditionalFee { get; set; }
        public bool AdditionalFee_OverrideForStore { get; set; }

        [DipSkyResourceDisplayName("Plugins.Payment.CheckMoneyOrder.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
        public bool AdditionalFeePercentage_OverrideForStore { get; set; }
    }
}