using System.Data.Entity.ModelConfiguration;
using DIPSky.Plugin.Tax.CountryStateZip.Domain;

namespace DIPSky.Plugin.Tax.CountryStateZip.Data
{
    public partial class TaxRateMap : EntityTypeConfiguration<TaxRate>
    {
        public TaxRateMap()
        {
            this.ToTable("TaxRate");
            this.HasKey(tr => tr.Id);
            this.Property(tr => tr.Percentage).HasPrecision(18, 4);
        }
    }
}