using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.Match
{
    public class MatchConfiguration : IEntityTypeConfiguration<Models.Match.Match>
    {
        public void Configure(EntityTypeBuilder<Models.Match.Match> builder)
        {
            builder.Property(x => x.MatchId).IsRequired().ValueGeneratedNever();

            builder.HasKey(x => x.MatchId);
        }
    }
}