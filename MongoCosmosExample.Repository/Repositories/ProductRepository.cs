using MongoCosmosExample.Data.Context;
using MongoCosmosExample.Domain.Entities;
using MongoCosmosExample.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
