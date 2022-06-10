using BP.Models.ReservationPayment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.ReservationPayment
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.Property(x => x.PaymentId).IsRequired().ValueGeneratedNever();

            builder.HasKey(x => x.PaymentId);
        }
    }
}
