using AutoShop_ASPNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Repositories
{
    public interface IProductsRepository
    {
        List<Product> GetAll();
        Product? TryGetById(int id);
        List<Product> RemoveItemById(int id);
    }
}