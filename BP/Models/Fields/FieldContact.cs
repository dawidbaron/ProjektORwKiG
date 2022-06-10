using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BP.Domain;

namespace BP.Models.Fields
{
    [Table("FieldContact")]
    public class FieldContact 
    {
        [Key]
        [ForeignKey("Field")]
        public Guid FieldId { get; set; }
        public string FieldContactName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public virtual Field Field { get; set; }
        //protected FieldContact()
        //{
        //}
        //public FieldContact(Guid id, string name,string email,string phoneNumber,Guid fieldId) : base(id)
        //{
        //    Name = name;
        //    Email = email;
        //    PhoneNumber = phoneNumber;
        //    FieldId = fieldId;
        //}
    }
}
