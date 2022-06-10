using BP.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config
{
    public class UserConfiguration :IEntityTypeConfiguration<BP.Models.User.User>
    {
        public void Configure(EntityTypeBuilder<BP.Models.User.User> builder)
        {
            builder.Property(x => x.UserId).IsRequired().ValueGeneratedNever();

            builder.HasKey(x => x.UserId);
        }
    }
}
