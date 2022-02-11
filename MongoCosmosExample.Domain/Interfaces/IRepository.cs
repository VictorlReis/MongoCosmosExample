namespace MongoCosmosExample.Repository.Interfaces;

public interface IRepository<T>
{
    IQueryable<T> QueryAll();

    T QueryByKey(Guid key);
}