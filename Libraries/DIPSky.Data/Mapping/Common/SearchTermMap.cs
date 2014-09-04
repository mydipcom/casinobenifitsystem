using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Common;

namespace DIPSky.Data.Mapping.Common
{
    public partial class SearchTermMap : EntityTypeConfiguration<SearchTerm>
    {
        public SearchTermMap()
        {
            this.ToTable("SearchTerm");
            this.HasKey(st => st.Id);
        }
    }
}
