using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BP.Models.User
{
    [Table("LoginPrivilage")]
    public class LoginPrivilage 
    {
        [Key]
        public Guid LoginPrivilageId { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public DateTime LastPasswordChangeDate { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        //protected LoginPrivilage()
        //{

        //}
        //public LoginPrivilage( string login, Guid userId, string passwordHash, DateTime lastPasswordChangeDate, DateTime createdOn, DateTime modifiedOn)
        //{
        //    Login = login;
        //    UserId = userId;
        //    PasswordHash = passwordHash;
        //    LastPasswordChangeDate = lastPasswordChangeDate;
        //    CreatedOn = createdOn;
        //    ModifiedOn = modifiedOn;
        //}
    }
}
