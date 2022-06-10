//using BP.Models.Fields;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace BP.Models.ReservationPayment
//{
//    [Table("Receipt")]
//    public class Receipt
//    {
//        [Key]
//        public Guid ReceiptId { get; set; }
//        public Guid FieldId { get; set; }
//        public virtual Field Field { get; set; }
//        public Guid ReservationId { get; set; }
//        public virtual Reservation Reservation { get; set; }
//        public double TotalPrice { get; set; }
//        public Guid PaymentId { get; set; }
//        public virtual Payment Payment { get; set; }
      
//    }
//}