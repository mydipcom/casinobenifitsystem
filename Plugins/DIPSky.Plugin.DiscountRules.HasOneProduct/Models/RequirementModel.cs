using DIPSky.Web.Framework;

namespace DIPSky.Plugin.DiscountRules.HasOneProduct.Models
{
    public class RequirementModel
    {
        [DipSkyResourceDisplayName("Plugins.DiscountRules.HasOneProduct.Fields.Products")]
        public string Products { get; set; }

        public int DiscountId { get; set; }

        public int RequirementId { get; set; }
    }
}