using BP.Domain;
using System;

namespace BP.Models.ReservationPayment
{
    public class PaymentStatusDictionary : EntityBase
    {
        public string Name { get; set; }
        public Guid PaymentId { get; set; }
        protected PaymentStatusDictionary()
        { }
        public PaymentStatusDictionary(Guid id,string name,Guid paymentId):base(id)
        { 
            Name = name;
            PaymentId = paymentId;
        }
    }
}
