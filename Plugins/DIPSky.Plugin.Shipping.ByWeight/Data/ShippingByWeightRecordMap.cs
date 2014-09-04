using System.Data.Entity.ModelConfiguration;
using DIPSky.Plugin.Shipping.ByWeight.Domain;

namespace DIPSky.Plugin.Shipping.ByWeight.Data
{
    public partial class ShippingByWeightRecordMap : EntityTypeConfiguration<ShippingByWeightRecord>
    {
        public ShippingByWeightRecordMap()
        {
            this.ToTable("ShippingByWeight");
            this.HasKey(x => x.Id);

            this.Property(x => x.Zip).HasMaxLength(400);
        }
    }
}