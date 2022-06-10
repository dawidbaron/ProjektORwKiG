using BP.Models.ReservationPayment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.ReservationPayment
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            //builder.Property(x => x.ReservationId).IsRequired().ValueGeneratedNever();

            //builder.HasKey(x => x.ReservationId);
        }
    }
}