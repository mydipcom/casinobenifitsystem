using DIPSky.Web.Framework;

namespace DIPSky.Plugin.DiscountRules.HadSpentAmount.Models
{
    public class RequirementModel
    {
        [DipSkyResourceDisplayName("Plugins.DiscountRules.HadSpentAmount.Fields.Amount")]
        public decimal SpentAmount { get; set; }

        public int DiscountId { get; set; }

        public int RequirementId { get; set; }
    }
}