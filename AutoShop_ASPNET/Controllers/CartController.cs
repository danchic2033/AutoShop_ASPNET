using AutoShop_ASPNET.Models;
using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = CartRepository.GetCart();

            return View(cart);
        }

        public IActionResult AddToCart(int id)
        {
            var product = ProductsRepository.TryGetById(id);

            CartRepository.AddItemToCart(product, 1, product.Cost);

            return RedirectToAction("Index", "Home");
        }
    }
}
