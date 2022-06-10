using BP.Domain;
using System;

namespace BP.Models.ReservationPayment
{
    public class ReservationMatch : EntityBase
    {
        public int ReservationId { get; set; }
        public Guid MatchId { get; set; }
        protected ReservationMatch()
        {

        }
        public ReservationMatch(Guid id, int reservationId, Guid matchId) : base(id)
        {
            ReservationId = reservationId;
            MatchId = matchId;
        }
    }
}

