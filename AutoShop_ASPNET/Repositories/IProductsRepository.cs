using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public interface IProductsRepository
    {
        List<Product> GetAll();
        Product? TryGetById(int id);
    }
}