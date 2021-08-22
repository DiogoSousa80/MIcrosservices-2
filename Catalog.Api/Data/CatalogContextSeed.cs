using Catalog.Api.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Data
{
    public class CatalogContextSeed
    {
        private static object productCollection;

        public CatalogContextSeed()
        {
        }

     public static void SeedData(IMongoCollection<Product>mongoCollection)
        {
            bool existProduct = productCollection.find(p => true)
                .Any();
            if (!existProduct)

            {
                object productCollection = null;
                object p = productCollection.InsertManyAsybc(GetMyProducts());
            }
                    
                    
       }

        private static object GetMyProducts()
        {
            throw new NotImplementedException();
        }
    }
}
