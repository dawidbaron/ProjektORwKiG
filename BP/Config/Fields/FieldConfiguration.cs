using BP.Models.Fields;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.Fields
{
    public class FieldConfiguration : IEntityTypeConfiguration<Field>
    {
        public void Configure(EntityTypeBuilder<Field> builder)
        {
            builder.Property(x => x.FieldId).IsRequired().ValueGeneratedNever();

            builder.HasKey(x => x.FieldId);
        }
    }
}