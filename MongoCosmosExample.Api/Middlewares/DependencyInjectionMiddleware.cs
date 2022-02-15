using MongoCosmosExample.Domain.Entities;
using MongoCosmosExample.Repository.Base;
using MongoCosmosExample.Repository.Interfaces;
using MongoCosmosExample.Service;
using MongoCosmosExample.Service.Interfaces;

namespace MongoCosmosExample.Api.Middlewares;
public static class DependencyInjectionMiddleware
{
    public static void AddDependencyInjection(this IServiceCollection services)
    {
        services.AddSingleton<IRepository<Product>, Repository<Product>>();
        services.AddTransient<IProductService, ProductService>();
    }    
}
