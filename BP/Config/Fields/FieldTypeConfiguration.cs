using BP.Models.Fields;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.Fields
{
    public class FieldTypeConfiguration : IEntityTypeConfiguration<FieldType>
    {
        public void Configure(EntityTypeBuilder<FieldType> builder)
        {
            //    builder.Property(x => x.FieldId).IsRequired().ValueGeneratedNever();

            //    builder.HasKey(x => x.FieldId);
        }
    }
}