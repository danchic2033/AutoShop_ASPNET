using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id)
        {
            var product = ProductsRepository.TryGetById(id);

            if (product == null)
            {
                return $"Товара с Id {id} не существует";
            }

            return $"{product}{product.Description}";
        }
    }
}
