using System;

namespace BP.Services.Reservation.Requests
{
    public class CreateReservationRequest
    {
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

        //public string Name { get; set; }
        //public DateTime OpenTime { get; set; }
        //public DateTime CloseTime { get; set; }
        //public string City { get; set; }
        //public string Address { get; set; }
        //public string Description { get; set; } 
        //public string PathUrl { get; set; }
        //public string ImgUrl { get; set; }
        //public double PriceHour { get; set; }
        //public int DefaultPlayerLimit { get; set; }
        //public bool Payable { get; set; }

        //public string SportName { get; set; }

        //public string FieldName { get; set; }

        //public string Email { get; set; }
        //public string FirstName { get; set; }
        //public string SecondName { get; set; }
        //public int RoleId { get; set; } //admin czy nie
        //public string PhoneNo { get; set; }
        //public int UserTypeId { get; set; } // organizator 
        //public int Absence { get; set; } // 3 nieobecnosci -> ban 
        public CreateReservationRequest( Guid fieldId, Guid userId, Guid matchId, Guid paymentId,
            Guid reservationMatchId, Guid reservationStatusDictionaryId, Guid reservationPaymentId, string title, DateTime start,
            DateTime end, double totalPrice, int statusId)
        {
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
