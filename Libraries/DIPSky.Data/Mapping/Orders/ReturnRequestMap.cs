using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Orders;

namespace DIPSky.Data.Mapping.Orders
{
    public partial class ReturnRequestMap : EntityTypeConfiguration<ReturnRequest>
    {
        public ReturnRequestMap()
        {
            this.ToTable("ReturnRequest");
            this.HasKey(rr => rr.Id);
            this.Property(rr => rr.ReasonForReturn).IsRequired();
            this.Property(rr => rr.RequestedAction).IsRequired();

            this.Ignore(rr => rr.ReturnRequestStatus);

            this.HasRequired(rr => rr.Customer)
                .WithMany(c => c.ReturnRequests)
                .HasForeignKey(rr => rr.CustomerId);
        }
    }
}