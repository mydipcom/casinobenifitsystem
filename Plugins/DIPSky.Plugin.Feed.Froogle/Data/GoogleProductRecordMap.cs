using System.Data.Entity.ModelConfiguration;
using DIPSky.Plugin.Feed.Froogle.Domain;

namespace DIPSky.Plugin.Feed.Froogle.Data
{
    public partial class GoogleProductRecordMap : EntityTypeConfiguration<GoogleProductRecord>
    {
        public GoogleProductRecordMap()
        {
            this.ToTable("GoogleProduct");
            this.HasKey(x => x.Id);
        }
    }
}