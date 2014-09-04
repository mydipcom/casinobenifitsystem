using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Catalog;

namespace DIPSky.Data.Mapping.Catalog
{
    public partial class ProductAttributeMap : EntityTypeConfiguration<ProductAttribute>
    {
        public ProductAttributeMap()
        {
            this.ToTable("ProductAttribute");
            this.HasKey(pa => pa.Id);
            this.Property(pa => pa.Name).IsRequired();
        }
    }
}