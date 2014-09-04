using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Catalog;

namespace DIPSky.Data.Mapping.Catalog
{
    public partial class SpecificationAttributeOptionMap : EntityTypeConfiguration<SpecificationAttributeOption>
    {
        public SpecificationAttributeOptionMap()
        {
            this.ToTable("SpecificationAttributeOption");
            this.HasKey(sao => sao.Id);
            this.Property(sao => sao.Name).IsRequired();
            
            this.HasRequired(sao => sao.SpecificationAttribute)
                .WithMany(sa => sa.SpecificationAttributeOptions)
                .HasForeignKey(sao => sao.SpecificationAttributeId);
        }
    }
}