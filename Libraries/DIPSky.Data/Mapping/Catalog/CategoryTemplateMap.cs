using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Catalog;

namespace DIPSky.Data.Mapping.Catalog
{
    public partial class CategoryTemplateMap : EntityTypeConfiguration<CategoryTemplate>
    {
        public CategoryTemplateMap()
        {
            this.ToTable("CategoryTemplate");
            this.HasKey(p => p.Id);
            this.Property(p => p.Name).IsRequired().HasMaxLength(400);
            this.Property(p => p.ViewPath).IsRequired().HasMaxLength(400);
        }
    }
}