using BP.Models.Fields;
using BP.Models.ReservationPayment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BP.Models.Match
{
    [Table("Match")]
    public class Match 
    {
        [Key]
        public Guid MatchId { get; set; }
        public Guid FieldId { get; set; }
        public virtual Field Field { get; set; }
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
        public Guid UserId { get; set; }
        public virtual ICollection<User.User> User { get; set; }
        public int? PlayerLimit { get; set; }
        public int CurrentPlayers { get; set; }
        public bool PublicGame { get; set; }
        public double PriceForPerson { get; set; }
        //protected Match()
        //{
        //}
        //public Match(Guid id,Guid matchUserId, Guid fieldId,Guid reservationMatchId,int playerLimit,int currentPlayers,bool publicGame,double priceForPerson) : base(id)
        //{
        //    MatchUsersId = matchUserId;
        //    FieldId = fieldId;
        //    ReservationMatchId = reservationMatchId;
        //    PlayerLimit = playerLimit;
        //    CurrentPlayers = currentPlayers;
        //    PublicGame = publicGame;
        //    PriceForPerson= priceForPerson;
        //}
    }
}
