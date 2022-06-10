using BP.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using UserModel = BP.Models.User.User;
using System.Threading.Tasks;
using BP.Domain;

namespace BP.Models.Match
{
    public class MatchUsers : EntityBase
    {
        public Guid UserId { get; set; }
        public Guid MatchId { get; set; }
        public virtual UserModel User { get; set; }
        public virtual Match Match { get; set; }
        protected MatchUsers()
        {

        }
        public MatchUsers(Guid id, Guid userId, Guid matchId) : base(id)
        {
            UserId = userId;
            MatchId = matchId;
        }
    }
}
