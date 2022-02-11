using MongoDB.Driver;

namespace MongoCosmosExample.Data.Context;

public interface IConnectionFactory
{
    IMongoClient GetClient();

    IMongoDatabase GetDatabase(IMongoClient mongoClient, string databaseName);

    IMongoDatabase GetDatabase(string databaseName);
}