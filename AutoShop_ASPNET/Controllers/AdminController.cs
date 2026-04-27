using AutoShop_ASPNET.Models;
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

        public IActionResult EditItem(int id)
        {
            var product = _productsRepository.TryGetById(id);

            return View(product);
        }

        public IActionResult SaveItem(Product product)
        {
            var productEdit = _productsRepository.TryGetById(product.Id);

            productEdit.Name = product.Name;
            productEdit.Description = product.Description;
            productEdit.Cost = product.Cost;

            return RedirectToAction("Products");
        }
    }
}
