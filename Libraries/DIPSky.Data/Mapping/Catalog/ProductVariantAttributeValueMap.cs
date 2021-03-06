using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Catalog;

namespace DIPSky.Data.Mapping.Catalog
{
    public partial class ProductVariantAttributeValueMap : EntityTypeConfiguration<ProductVariantAttributeValue>
    {
        public ProductVariantAttributeValueMap()
        {
            this.ToTable("ProductVariantAttributeValue");
            this.HasKey(pvav => pvav.Id);
            this.Property(pvav => pvav.Name).IsRequired().HasMaxLength(400);
            this.Property(pvav => pvav.ColorSquaresRgb).HasMaxLength(100);

            this.Property(pvav => pvav.PriceAdjustment).HasPrecision(18, 4);
            this.Property(pvav => pvav.WeightAdjustment).HasPrecision(18, 4);
            this.Property(pvav => pvav.Cost).HasPrecision(18, 4);

            this.Ignore(pvav => pvav.AttributeValueType);

            this.HasRequired(pvav => pvav.ProductVariantAttribute)
                .WithMany(pva => pva.ProductVariantAttributeValues)
                .HasForeignKey(pvav => pvav.ProductVariantAttributeId);
        }
    }
}