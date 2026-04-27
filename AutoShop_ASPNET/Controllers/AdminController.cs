using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        public AdminController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Roles()
        {
            return View();
        }
        public IActionResult Products()
        {
            var products = _productsRepository.GetAll();

            return View(products);
        }

        public IActionResult RemoveItem(int id)
        {
            _productsRepository.RemoveItemById(id);

            return RedirectToAction("Products");
        }
    }
}
