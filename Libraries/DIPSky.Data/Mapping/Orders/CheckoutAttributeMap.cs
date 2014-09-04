using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Orders;

namespace DIPSky.Data.Mapping.Orders
{
    public partial class CheckoutAttributeMap : EntityTypeConfiguration<CheckoutAttribute>
    {
        public CheckoutAttributeMap()
        {
            this.ToTable("CheckoutAttribute");
            this.HasKey(ca => ca.Id);
            this.Property(ca => ca.Name).IsRequired().HasMaxLength(400);

            this.Ignore(pva => pva.AttributeControlType);
        }
    }
}