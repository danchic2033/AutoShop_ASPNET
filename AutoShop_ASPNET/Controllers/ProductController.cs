using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int id)
        {
            var product = ProductsRepository.TryGetById(id);

            return View(product);
        }
    }
}
