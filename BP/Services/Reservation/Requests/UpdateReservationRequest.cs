using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP.Services.Reservation.Requests
{
    public class UpdateReservationRequest
    {
        public Guid Id { get; set; }
        public Guid FieldId { get; set; }
        public Guid UserId { get; set; }
        public Guid MatchId { get; set; }
        public Guid PaymentId { get; set; }
        public Guid ReservationMatchId { get; set; }
        public Guid ReservationStatusDictionaryId { get; set; }
        public Guid ReservationPaymentId { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public double TotalPrice { get; set; }
        public int StatusId { get; set; }
        public UpdateReservationRequest(Guid id, Guid fieldId, Guid userId, Guid matchId, Guid paymentId,
            Guid reservationMatchId, Guid reservationStatusDictionaryId, Guid reservationPaymentId, string title, DateTime start,
            DateTime end, double totalPrice, int statusId)
        {
            Id = id;
            FieldId = fieldId;
            UserId = userId;
            MatchId = matchId;
            PaymentId = paymentId;
            ReservationMatchId = reservationMatchId;
            ReservationStatusDictionaryId = reservationStatusDictionaryId;
            ReservationPaymentId = reservationPaymentId;
            Title = title;
            Start = start;
            End = end;
            TotalPrice = totalPrice;
            StatusId = statusId;
        }
    }
}
