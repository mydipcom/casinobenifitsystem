using DIPSky.Web.Framework;

namespace DIPSky.Plugin.DiscountRules.HasAllProducts.Models
{
    public class RequirementModel
    {
        [DipSkyResourceDisplayName("Plugins.DiscountRules.HasAllProducts.Fields.Products")]
        public string Products { get; set; }

        public int DiscountId { get; set; }

        public int RequirementId { get; set; }
    }
}