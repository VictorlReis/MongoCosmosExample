﻿using MongoCosmosExample.Domain.Entities;
using MongoCosmosExample.Repository.Interfaces;

namespace MongoCosmosExample.Service;

public class ProductService
{
    private readonly IRepository<Product> _productRepository;

    public ProductService(IRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }

    public IQueryable<Product> QueryAll() => _productRepository.QueryAll();

    public Product QueryByKey(Guid key) => _productRepository.QueryByKey(key);
}