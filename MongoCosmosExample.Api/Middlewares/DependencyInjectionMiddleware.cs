using MongoCosmosExample.Data.Context;
using MongoCosmosExample.Domain.Entities;
using MongoCosmosExample.Domain.Settings;
using MongoCosmosExample.Repository.Base;
using MongoCosmosExample.Repository.Interfaces;
using MongoCosmosExample.Repository.Repositories;
using MongoCosmosExample.Service;
using MongoCosmosExample.Service.Interfaces;

namespace MongoCosmosExample.Api.Middlewares;
public static class DependencyInjectionMiddleware
{
    public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        var mongoDbSettings = configuration.GetSection("MongoDBSetting").Get<MongoDbSettings>();

        var connectionFactory = new ConnectionFactory(mongoDbSettings.ConnectionString);

        services.AddSingleton<IRepository<Product>>(
            p => new ProductRepository(connectionFactory, mongoDbSettings.DatabaseName,
            mongoDbSettings.CollectionName));

        services.AddTransient<IProductService, ProductService>();
    }
}
