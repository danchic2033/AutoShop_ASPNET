using AutoShop_ASPNET.Models;
using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class CartController : Controller
    {
        private readonly CartRepository _cartRepository;
        private readonly ProductsRepository _productsRepository;

        public CartController(CartRepository cartRepository, ProductsRepository productsRepository)
        {
            _cartRepository = cartRepository;
            _productsRepository = productsRepository;
        }

        public IActionResult Index()
        {
            var cart = _cartRepository.GetCart();

            return View(cart);
        }

        public IActionResult AddToCart(int id)
        {
            var product = _productsRepository.TryGetById(id);

            _cartRepository.AddItemToCart(product, 1);

            return RedirectToAction("Index", "Home");
        }
    }
}
