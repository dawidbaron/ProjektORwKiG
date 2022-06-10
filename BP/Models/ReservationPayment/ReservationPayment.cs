using BP.Domain;
using System;

namespace BP.Models.ReservationPayment
{
    public class ReservationPayment : EntityBase
    {
        public int ReservationId { get; set; }
        public Guid PaymentId { get; set; }
        protected ReservationPayment()
        {

        }
        public ReservationPayment(Guid id, int reservationId, Guid paymentId) : base(id)
        {
            ReservationId = reservationId;
            PaymentId = paymentId;
        }
    }
}
