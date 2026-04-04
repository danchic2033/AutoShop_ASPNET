using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        public HomeController(IProductsRepository productsRepository) 
        {
            _productsRepository = productsRepository;
        }
        public IActionResult Index()
        {
            var products = _productsRepository.GetAll();

            return View(products);
        }
    }
}
