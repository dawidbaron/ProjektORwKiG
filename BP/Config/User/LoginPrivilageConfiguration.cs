using BP.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config
{
    public class LoginPrivilageConfiguration :IEntityTypeConfiguration<LoginPrivilage>
    {
        public void Configure(EntityTypeBuilder<LoginPrivilage> builder)
        {
            builder.Property(x => x.Login).IsRequired().ValueGeneratedNever();

            builder.HasKey(x => x.Login);
        }
    }
}
