using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Views.Shared.Components.Cart
{
    public class CartViewComponent : ViewComponent
    {
        private readonly ICartRepository _cartRepository;

        public CartViewComponent(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cart = _cartRepository.GetCart();

            var productsCount = cart?.Quantity ?? 0;

            return View("Cart", productsCount);
        }
    }
}
