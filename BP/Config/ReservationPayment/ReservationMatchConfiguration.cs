using BP.Models.ReservationPayment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BP.Config.ReservationPayment
{
    public class ReservationMatchConfiguration : IEntityTypeConfiguration<ReservationMatch>
    {
        public void Configure(EntityTypeBuilder<ReservationMatch> builder)
        {
        }
    }
}