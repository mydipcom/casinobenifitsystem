﻿using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Logging;

namespace DIPSky.Data.Mapping.Logging
{
    public partial class ActivityLogTypeMap : EntityTypeConfiguration<ActivityLogType>
    {
        public ActivityLogTypeMap()
        {
            this.ToTable("ActivityLogType");
            this.HasKey(alt => alt.Id);

            this.Property(alt => alt.SystemKeyword).IsRequired().HasMaxLength(100);
            this.Property(alt => alt.Name).IsRequired().HasMaxLength(200);
        }
    }
}
