﻿using System.Data.Entity.ModelConfiguration;
using DIPSky.Core.Domain.Forums;

namespace DIPSky.Data.Mapping.Forums
{
    public partial class ForumGroupMap : EntityTypeConfiguration<ForumGroup>
    {
        public ForumGroupMap()
        {
            this.ToTable("Forums_Group");
            this.HasKey(fg => fg.Id);
            this.Property(fg => fg.Name).IsRequired().HasMaxLength(200);
        }
    }
}
