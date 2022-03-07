using MongoCosmosExample.Domain.Entities;
using MongoCosmosExample.Repository.Interfaces;
using MongoCosmosExample.Service.Interfaces;

namespace MongoCosmosExample.Service;

public class ProductService : IProductService
{
    private readonly IRepository<Product> _productRepository;

    public ProductService(IRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }

    public IQueryable<Product> QueryAll() => _productRepository.QueryAll();

    public Product QueryByKey(Guid key) => _productRepository.QueryByKey(key);

    public void Insert(Product product) => _productRepository.Insert(product);
    
}