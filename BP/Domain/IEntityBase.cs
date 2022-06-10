using System;
namespace BP.Domain
{
    public interface IEntityBase
    {
        Guid Id { get; }
        DateTimeOffset CreatedOn { get; }
        DateTimeOffset? ModifiedOn { get; }
    }

}