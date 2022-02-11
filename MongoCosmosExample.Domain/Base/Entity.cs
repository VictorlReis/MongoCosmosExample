using MongoCosmosExample.Domain.Interfaces;

namespace MongoCosmosExample.Domain.Base;

public abstract class Entity : IEntity
{
    public Guid Key { get; set; }

    protected Entity()
    {
        Key = Guid.NewGuid();
    }
}