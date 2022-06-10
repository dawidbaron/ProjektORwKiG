using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP.Domain
{
    public class EntityBase : IEntityBase
    {
        public Guid Id { get;  set; }
        public DateTimeOffset CreatedOn { get;  set; }
        public DateTimeOffset? ModifiedOn { get;  set; }

        protected EntityBase()
        {
        }

        public EntityBase(Guid id)
        {
            Id = id;
        }
    }
}
