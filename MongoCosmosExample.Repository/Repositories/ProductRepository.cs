using MongoCosmosExample.Data.Context;
using MongoCosmosExample.Domain.Entities;
using MongoCosmosExample.Repository.Base;

namespace MongoCosmosExample.Repository.Repositories
{
    public sealed class ProductRepository : Repository<Product>
    {
        public ProductRepository(IConnectionFactory connectionFactory, string databaseName, string collectionName)
            : base(connectionFactory, databaseName, collectionName)
        {
        }
    }
}