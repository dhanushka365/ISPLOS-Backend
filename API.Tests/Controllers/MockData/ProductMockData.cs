using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Tests.Controllers.MockData
{
    public class ProductMockData
    {
        public static List<Product> GetProducts()
        {
            // This is just a sample list of products for testing
            return new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Product 1", Price = 10.99m, Description="ABC", PictureUrl="ABC", CreatedAt= DateTime.Now, UpdatedAt= DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Product 2", Price = 19.99m ,  Description="ABC", PictureUrl="ABC", CreatedAt= DateTime.Now, UpdatedAt= DateTime.Now },
                new Product {Id = Guid.NewGuid(), Name = "Product 3", Price = 5.99m, Description = "ABC", PictureUrl = "ABC", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
            };
        }
    }
}
