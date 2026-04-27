using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public class InMemoryProductsRepository : IProductsRepository
    {
        private int _idProduct = 1;
        private readonly List<Product> _products;

        public InMemoryProductsRepository()
        {
            _products =
            [
                new Product {Id = _idProduct++, Name = "Товар 1", Cost = 1000, Description = "Описание 1" },
                new Product {Id = _idProduct++, Name = "Товар 2", Cost = 2000, Description = "Описание 2" },
                new Product {Id = _idProduct++, Name = "Товар 3", Cost = 3000, Description = "Описание 3" },
                new Product {Id = _idProduct++, Name = "Товар 4", Cost = 4000, Description = "Описание 4" }
            ];
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product? TryGetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> RemoveItemById(int id)
        {
            _products.RemoveAt(id);
            return _products;
        }

        public void AddItem (Product product)
        {
            _products.Add(product);
        }
    }
}
