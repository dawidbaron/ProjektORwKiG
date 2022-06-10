using BP.Models.Fields;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.Fields
{
    public class SportTypeConfiguration : IEntityTypeConfiguration<SportType>
    {
        public void Configure(EntityTypeBuilder<SportType> builder)
        {
            //builder.Property(x => x.FieldId).IsRequired().ValueGeneratedNever();

            //builder.HasKey(x => x.FieldId);
        }
    }
}