using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BP.Models.User
{
    [Table("UserTypeDictionary")]
    public class UserTypeDictionary
    {
        [Key]
        public Guid UserTypeDictionaryId { get; set; }
        public string Name { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        //protected UserTypeDictionary()
        //{ }
        //public UserTypeDictionary(Guid id,Guid userId,string name):base(id)
        //{
        //    Name = name;
        //    UserId = userId;
        //}
    }
}
