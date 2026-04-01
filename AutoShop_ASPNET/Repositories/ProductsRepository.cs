using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public static class ProductsRepository
    {
        private static int _idProduct = 1;
        private static readonly List<Product> _products =
        [
            new Product {Id = _idProduct++, Name = "Товар 1", Cost = 1000, Description = "Описание 1" },
            new Product {Id = _idProduct++, Name = "Товар 2", Cost = 2000, Description = "Описание 2" },
            new Product {Id = _idProduct++, Name = "Товар 3", Cost = 3000, Description = "Описание 3" },
            new Product {Id = _idProduct++, Name = "Товар 4", Cost = 4000, Description = "Описание 4" }
        ];

        public static List<Product> GetAll()
        {
            return _products;
        }

        public static Product? TryGetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
