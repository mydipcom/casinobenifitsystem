using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Catalog;

namespace DIPSky.Data.Mapping.Catalog
{
    public partial class CrossSellProductMap : EntityTypeConfiguration<CrossSellProduct>
    {
        public CrossSellProductMap()
        {
            this.ToTable("CrossSellProduct");
            this.HasKey(c => c.Id);
        }
    }
}