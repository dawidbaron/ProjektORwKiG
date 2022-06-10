using BP.Models.ReservationPayment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.ReservationPayment
{
    public class ReservationPaymentConfiguration : IEntityTypeConfiguration<Models.ReservationPayment.ReservationPayment>
    {
        public void Configure(EntityTypeBuilder<Models.ReservationPayment.ReservationPayment> builder)
        {
        }
    }
}