using BP.Models.Match;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.Match
{
    public class MatchUserConfiguration : IEntityTypeConfiguration<MatchUsers>
    {
        public void Configure(EntityTypeBuilder<MatchUsers> builder)
        {
        }
    }
}