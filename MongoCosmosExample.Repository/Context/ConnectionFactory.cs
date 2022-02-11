﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCosmosExample.Data.Context;

public sealed class ConnectionFactory : IConnectionFactory
{
    private readonly string _connectionString;

    public ConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IMongoClient GetClient()
    {
        return new MongoClient(_connectionString);
    }

    public IMongoDatabase GetDatabase(IMongoClient mongoClient, string databaseName)
    {
        return mongoClient.GetDatabase(databaseName);
    }

    public IMongoDatabase GetDatabase(string databaseName)
    {
        var mongoClient = GetClient();

        return mongoClient.GetDatabase(databaseName);
    }
}

