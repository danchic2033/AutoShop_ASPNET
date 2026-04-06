using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartRepository _cartRepository;
        public OrderController (ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        
        public IActionResult SuccessOrder()
        {
            _cartRepository.RemoveCart();
            return View("SuccessOrder");
        }

        public IActionResult Index()
        {
            var cart = _cartRepository.GetCart();
            return View(cart);
        }
    }
}
