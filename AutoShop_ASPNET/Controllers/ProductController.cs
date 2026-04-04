using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductsRepository _productsRepository;

        public ProductController(ProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public IActionResult Index(int id)
        {
            var product = _productsRepository.TryGetById(id);

            return View(product);
        }
    }
}
