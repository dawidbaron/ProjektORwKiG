using BP.Models.ReservationPayment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.ReservationPayment
{
    public class PaymentStatusDictionaryConfiguration : IEntityTypeConfiguration<PaymentStatusDictionary>
    {
        public void Configure(EntityTypeBuilder<PaymentStatusDictionary> builder)
        {
            builder.Property(x => x.Id).IsRequired().ValueGeneratedNever();

            builder.HasKey(x => x.Id);
        }
    }
}