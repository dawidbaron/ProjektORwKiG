using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BP.Domain;

namespace BP.Models.Fields
{
    [Table("SportType")]
    public class SportType
    {
        [Key]
        [ForeignKey("Field")]
        public Guid FieldId { get; set; }
        public string SportName { get; set; }
        public virtual Field Field { get; set; }
        //    protected SportType()
        //    {
        //    }
        //    public SportType(Guid id, string sportName,Guid fieldId) : base(id)
        //    {
        //        SportName = sportName;
        //        FieldId = fieldId;
        //    }
    }
}
