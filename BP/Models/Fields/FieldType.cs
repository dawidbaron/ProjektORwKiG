using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BP.Domain;

namespace BP.Models.Fields
{
    [Table("FieldType")]
    public class FieldType 
    {
        [Key]
        [ForeignKey("Field")]
        public Guid FieldId { get; set; }
        public string FieldTypeName { get; set; }
        public virtual Field Field { get; set; }
        //protected FieldType()
        //{
        //}
        //public FieldType(Guid id, string fieldName,Guid fieldId) : base(id)
        //{
        //    FieldName = fieldName;
        //    FieldId = fieldId;
        //}
    }
}
