using BP.Models.ReservationPayment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BP.Models.User
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoleId { get; set; } //admin czy nie
        public string PhoneNo { get; set; }
        public string Login { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int UserTypeId { get; set; } // organizator 
        public int Absence { get; set; } // 3 nieobecnosci -> ban 
       // public Guid LoginPrivilageId { get; set; }
      //  public Guid RoleDictionaryId { get; set; }
       //// public Guid UserTypeDictionaryId { get; set; }
       // public Guid MatchId { get; set; }
        //public virtual LoginPrivilage LoginPrivilage { get; set; }
        public virtual ICollection<Match.Match> Match { get; set; }
        //public virtual RoleDictionary RoleDictionary { get; set; }
        //public virtual UserTypeDictionary UserTypeDictionary { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        //protected User()
        //{

        //}
        //public User(Guid id, string emailAddress, string firstName, string lastName, int roleId,
        //    string phoneNo, int userTypeId, int absence, Guid loginPrivilageId, Guid roleDictionaryId,
        //    Guid userTypeDictionaryId, Guid matchUsersId) : base(id)
        //{
        //    EmailAddress = emailAddress;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    RoleId = roleId;
        //    PhoneNo = phoneNo;
        //    UserTypeId = userTypeId;
        //    Absence = absence;
        //}
    }
}
