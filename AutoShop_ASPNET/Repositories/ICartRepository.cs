using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public interface ICartRepository
    {
        void AddItemToCart(Product product);
        Cart GetCart();
        void RemoveCart();
        void RemoveItemFromCart(int id);
    }
}