using Catalog.Api.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Data
{
    public class CatalogContext : ICatalogContext
    {
    
    
    public CatalogContext(IConfiguration confiration)
        {
            var client = new MongoClient(confiration.GetValue<string>
                ("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(confiration.GetValue<string>
                    ("DatabaseSettings:DatabaseName"));
            Products = database.GetCollection<Product>(confiration.GetValue<string>
                ("DatabaseSettings:ConnectionName"));

            CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }

        public IMongoCollection<Product> Product => throw new NotImplementedException();
    }











}
