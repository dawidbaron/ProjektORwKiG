using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BP.Models.ReservationPayment;

namespace BP.Models.Fields
{
    [Table("Field")]
    public class Field 
    {
        [Key]
        public Guid FieldId { get; set; }
        //public Guid FieldTypeId { get; set; }
        //public Guid FieldContactId { get; set; }
        //public Guid SportTypeId { get; set; }
        public string FieldName { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string PathUrl { get; set; }
        public string ImgUrl { get; set; }
        public double PriceHour { get; set; }
        public bool Payable { get; set; }
        public int DefaultPlayerLimit { get; set; }
        public string FieldTypeName { get; set; }
        public string FieldContactName { get; set; }
        public string FieldContactEmail { get; set; }
        public string FieldContactPhoneNumber { get; set; }
        public string SportTypeNames { get; set; }
        public string Dimensions { get; set; }
        public virtual ICollection<Match.Match> Match { get; set; }
        public virtual ICollection<Reservation> Reservations {get;set;}
        
        //public Field(Guid id, Guid fieldTypeId,Guid fieldContactId,Guid sportTypeId,string name,DateTime openTime,DateTime closeTime,string city,string address,string description,string pathUrl,string imgUrl,
        //    double priceHour,int defaultPlayerLimit,bool payable) : base(id)
        //{
        //    FieldTypeId = fieldTypeId;
        //    FieldContactId = fieldContactId;
        //    SportTypeId = sportTypeId;
        //    Name = name;
        //    OpenTime = openTime;
        //    CloseTime = closeTime;
        //    City = city;
        //    Address = address;
        //    Description = description;
        //    PathUrl = pathUrl;
        //    ImgUrl = imgUrl;
        //    PriceHour = priceHour;
        //    DefaultPlayerLimit = defaultPlayerLimit;
        //    Payable = payable;
        //}
    }
}
