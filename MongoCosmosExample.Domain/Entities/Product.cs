using MongoCosmosExample.Domain.Base;

namespace MongoCosmosExample.Domain.Entities;
public class Product : Entity
{
    public string Name { get; set; }

    public string Description { get; set; }
}

