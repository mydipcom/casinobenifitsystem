using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Localization;

namespace DIPSky.Data.Mapping.Localization
{
    public partial class LocaleStringResourceMap : EntityTypeConfiguration<LocaleStringResource>
    {
        public LocaleStringResourceMap()
        {
            this.ToTable("LocaleStringResource");
            this.HasKey(lsr => lsr.Id);
            this.Property(lsr => lsr.ResourceName).IsRequired().HasMaxLength(200);
            this.Property(lsr => lsr.ResourceValue).IsRequired();


            this.HasRequired(lsr => lsr.Language)
                .WithMany(l => l.LocaleStringResources)
                .HasForeignKey(lsr => lsr.LanguageId);
        }
    }
}