using BP.Models.ReservationPayment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.ReservationPayment
{
    public class ReservationStatusDictionaryConfiguration : IEntityTypeConfiguration<ReservationStatusDictionary>
    {
        public void Configure(EntityTypeBuilder<ReservationStatusDictionary> builder)
        {
            builder.Property(x => x.Id).IsRequired().ValueGeneratedNever();

            builder.HasKey(x => x.Id);
        }
    }
}