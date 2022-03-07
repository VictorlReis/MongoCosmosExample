using MongoCosmosExample.Data.Context;
using MongoCosmosExample.Domain.Entities;
using MongoCosmosExample.Domain.Interfaces;
using MongoCosmosExample.Repository.Interfaces;
using MongoDB.Driver;

namespace MongoCosmosExample.Repository.Base;

public abstract class Repository<T> : IRepository<T> where T : IEntity
{
    private readonly IMongoCollection<T> _collectionName;

    protected Repository(IMongoCollection<T> collectionName)
    {
        _collectionName = collectionName;
    }

    protected Repository(IConnectionFactory connectionFactory, string databaseName, string collectionName)
    {
        _collectionName = connectionFactory.GetDatabase(databaseName).GetCollection<T>(collectionName);
    }

    public void Insert(T obj) => _collectionName.InsertOne(obj);

    public IQueryable<T> QueryAll()
        => _collectionName.AsQueryable();

    public T QueryByKey(Guid key)
        => _collectionName.AsQueryable().FirstOrDefault(x => x.Key == key);
}