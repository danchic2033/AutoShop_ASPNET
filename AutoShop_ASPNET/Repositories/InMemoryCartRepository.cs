using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public class InMemoryCartRepository : ICartRepository
    {
        private List<CartItem> _cartItemsList;
        private Cart _cart;

        public void AddItemToCart(Product product, int itemQuantity)
        {
            var cartItem = new CartItem();
            cartItem.Product = product;
            cartItem.ItemQuantity = itemQuantity;

            _cartItemsList.Add(cartItem);
        }

        public void RemoveItemFromCart(int id)
        {
            for (int i = 0; i < _cartItemsList.Count; i++)
            {
                if (id == i)
                {
                    _cartItemsList.RemoveAt(i);
                }
            }
        }

        public Cart GetCart()
        {
            return _cart;
        }

        public void RemoveCart()
        {
            if (_cart.CartItems.Count > 0)
            {
                _cartItemsList.Clear();
            }
        }
    }
}
