﻿using BP.Models.Fields;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BP.Config.Fields
{
    public class FieldContactConfiguration : IEntityTypeConfiguration<FieldContact>
    {
        public void Configure(EntityTypeBuilder<FieldContact> builder)
        {
            //    builder.Property(x => x.FieldId).IsRequired().ValueGeneratedNever();

            //    builder.HasKey(x => x.FieldId);
        }
    }
}