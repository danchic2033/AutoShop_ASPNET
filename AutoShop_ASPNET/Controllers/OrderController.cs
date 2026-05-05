using AutoShop_ASPNET.Models;
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

        [HttpPost]
        public IActionResult SuccessOrder(DeliveryUserInfo deliveryUserInfo)
        {
            _cartRepository.RemoveCart();
            return View("SuccessOrder");
        }

        public IActionResult Index()
        {
            var cart = _cartRepository.GetCart();

            var order = new Order()
            {
                CartItems = cart?.CartItems ?? [],
            };

            return View(order);
        }
    }
}
