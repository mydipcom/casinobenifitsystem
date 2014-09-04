using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Polls;

namespace DIPSky.Data.Mapping.Polls
{
    public partial class PollVotingRecordMap : EntityTypeConfiguration<PollVotingRecord>
    {
        public PollVotingRecordMap()
        {
            this.ToTable("PollVotingRecord");
            this.HasKey(pr => pr.Id);

            this.HasRequired(pvr => pvr.PollAnswer)
                .WithMany(pa => pa.PollVotingRecords)
                .HasForeignKey(pvr => pvr.PollAnswerId);

            this.HasRequired(cc => cc.Customer)
                .WithMany()
                .HasForeignKey(cc => cc.CustomerId);
        }
    }
}