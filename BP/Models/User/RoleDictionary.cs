using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BP.Domain;

namespace BP.Models.User
{
    [Table("RoleDictionary")]
    public class RoleDictionary 
    {
        [Key]
        public Guid UserTypeDictionaryId { get; set; }
        public string Name { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        //protected RoleDictionary()
        //{ }
        //public RoleDictionary(Guid id,Guid userId,string name):base(id)
        //{
        //    Name = name;
        //    UserId = userId;
        //}
    }
}
