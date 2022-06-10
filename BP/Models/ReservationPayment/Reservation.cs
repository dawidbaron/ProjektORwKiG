using BP.Models.Fields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BP.Models.ReservationPayment
{
    [Table("Reservation")]
    public class Reservation 
    {
        [Key]
        public int ReservationId { get; set; }
        public Guid FieldId { get; set; }
        public virtual Field Field { get; set; }
        public Guid UserId { get; set; }
        public virtual User.User User { get; set; }
        [ForeignKey("MatchId")]
        public virtual Match.Match Match { get; set; }
        [ForeignKey("PaymentId")]
        public virtual Payment Payment { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; } //opłacona czy nie
        //protected Reservation()
        //{ }
        //public Reservation(Guid id,Guid fieldId,Guid userId,Guid matchId,Guid paymentId,
        //    Guid reservationMatchId,Guid reservationStatusDictionaryId,Guid reservationPaymentId, string title,DateTime start,
        //    DateTime end,double totalPrice,int statusId):base(id)
        //{ 
        //    FieldId = fieldId;
        //    UserId = userId;
        //    MatchId = matchId;
        //    PaymentId = paymentId;
        //    ReservationMatchId = reservationMatchId;
        //    ReservationStatusDictionaryId = reservationStatusDictionaryId;
        //    ReservationPaymentId = reservationPaymentId;
        //    Title = title;
        //    Start = start;
        //    End = end;
        //    TotalPrice = totalPrice;
        //    StatusId = statusId;
        //}
        //public static Reservation Create(Guid id, Guid fieldId, Guid userId, Guid matchId, Guid paymentId,
        //    Guid reservationMatchId, Guid reservationStatusDictionaryId, Guid reservationPaymentId, string title, DateTime start,
        //    DateTime end, double totalPrice, int statusId)
        //{
        //    return new Reservation(id,fieldId,userId,matchId,paymentId,reservationMatchId,reservationStatusDictionaryId,reservationPaymentId,title,start,end,totalPrice,statusId);
        //}
        //public void Update(Guid fieldId, Guid userId, Guid matchId, Guid paymentId,
        //    Guid reservationMatchId, Guid reservationStatusDictionaryId, Guid reservationPaymentId, string title, DateTime start,
        //    DateTime end, double totalPrice, int statusId)
        //{
        //    FieldId = fieldId;
        //    UserId = userId;
        //    MatchId = matchId;
        //    PaymentId = paymentId;
        //    ReservationMatchId = reservationMatchId;
        //    ReservationStatusDictionaryId = reservationStatusDictionaryId;
        //    ReservationPaymentId = reservationPaymentId;
        //    Title = title;
        //    Start = start;
        //    End = end;
        //    TotalPrice = totalPrice;
        //    StatusId = statusId;
        //}
    }
}
