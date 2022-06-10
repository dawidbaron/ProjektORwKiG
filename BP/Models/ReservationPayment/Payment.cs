using BP.Models.Fields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BP.Models.ReservationPayment
{
    [Table("Payment")]
    public class Payment 
    {
        [Key]
        public Guid PaymentId { get; set; }
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
        public Guid FieldId { get; set; }
        public virtual Field Field { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public string Status { get; set; }
        //protected Payment() 
        //{
        //}
        //public Payment(Guid id,DateTime date,int statusId,Guid reservationPaymentId,Guid paymentStatusDictionary):base(id)
        //{
        //    Date = date;
        //    StatusId = statusId;
        //    ReservationPaymentId = reservationPaymentId;
        //    PaymentStatusDictionaryId = PaymentStatusDictionaryId;
        //}
    }
}
