using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Polls;

namespace DIPSky.Data.Mapping.Polls
{
    public partial class PollAnswerMap : EntityTypeConfiguration<PollAnswer>
    {
        public PollAnswerMap()
        {
            this.ToTable("PollAnswer");
            this.HasKey(pa => pa.Id);
            this.Property(pa => pa.Name).IsRequired();

            this.HasRequired(pa => pa.Poll)
                .WithMany(p => p.PollAnswers)
                .HasForeignKey(pa => pa.PollId).WillCascadeOnDelete(true);
        }
    }
}