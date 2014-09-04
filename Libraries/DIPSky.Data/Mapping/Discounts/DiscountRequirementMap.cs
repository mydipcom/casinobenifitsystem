using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Discounts;

namespace DIPSky.Data.Mapping.Discounts
{
    public partial class DiscountRequirementMap : EntityTypeConfiguration<DiscountRequirement>
    {
        public DiscountRequirementMap()
        {
            this.ToTable("DiscountRequirement");
            this.HasKey(dr => dr.Id);
        }
    }
}