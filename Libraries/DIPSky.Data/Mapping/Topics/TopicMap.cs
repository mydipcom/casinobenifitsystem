using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Topics;

namespace DIPSky.Data.Mapping.Topics
{
    public class TopicMap : EntityTypeConfiguration<Topic>
    {
        public TopicMap()
        {
            this.ToTable("Topic");
            this.HasKey(t => t.Id);
        }
    }
}
