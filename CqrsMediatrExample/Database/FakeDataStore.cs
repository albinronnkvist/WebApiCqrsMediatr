using CqrsMediatrExample.Models;

namespace CqrsMediatrExample.Database
{
    public class FakeDataStore
    {
        private static List<Product> _products = new();
        public FakeDataStore()
        {
            _products = new List<Product>
            {
                new() { Id = 1, Name = "Test Product 1" },
                new() { Id = 2, Name = "Test Product 2" },
                new() { Id = 3, Name = "Test Product 3" }
            };
        }
        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Product>> GetAllProducts() => await Task.FromResult(_products);
    }
}
