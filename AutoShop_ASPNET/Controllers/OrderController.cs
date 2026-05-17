using AutoShop_ASPNET.Models;
using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartRepository _cartRepository;
        private readonly IOrderRepository _orderRepository;
        public OrderController (ICartRepository cartRepository, IOrderRepository orderRepository)
        {
            _cartRepository = cartRepository;
            _orderRepository = orderRepository;
        }

        [HttpPost]
        public IActionResult SuccessOrder(Order order)
        {
            var cart = _cartRepository.GetCart();

            order.CartItems = cart.CartItems.ToList();

            _orderRepository.AddOrder(order);
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
