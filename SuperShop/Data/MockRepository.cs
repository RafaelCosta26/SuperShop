using SuperShop.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public class MockRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "um", Price = 10 });
            products.Add(new Product { Id = 2, Name = "dois", Price = 20 });
            products.Add(new Product { Id = 3, Name = "tres", Price = 30 });
            products.Add(new Product { Id = 4, Name = "quatro", Price = 40 });
            products.Add(new Product { Id = 5, Name = "cinco", Price = 50 });

            return products;
        }

        public bool ProductExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
