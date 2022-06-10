using BP.Domain;
using System;

namespace BP.Models.ReservationPayment
{
    public class ReservationStatusDictionary : EntityBase
    {
        public string Name { get; set; }
        public int ReservationId { get; set; }
        protected ReservationStatusDictionary()
        { }
        public ReservationStatusDictionary(Guid id,int reservationId, string name) : base(id)
        {
            Name = name;
            ReservationId = reservationId;
        }
    }
}
