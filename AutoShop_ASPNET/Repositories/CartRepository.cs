using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public static class CartRepository
    {
        private static List<CartItem> _cartItemsList = new List<CartItem>();
        private static Cart _cart = new Cart(_cartItemsList);

        public static void AddItemToCart(Product product, int itemQuantity, decimal itemCost)
        {
            var cartItem = new CartItem();
            cartItem.Product = product;
            cartItem.ItemQuantity = itemQuantity;

            _cartItemsList.Add(cartItem);
        }

        public static void RemoveItemFromCart(int id)
        {
            for (int i = 0; i < _cartItemsList.Count; i++)
            {
                if (id == i)
                {
                    _cartItemsList.RemoveAt(i);
                }
            }
        }

        public static Cart GetCart()
        {
            return _cart;
        }

        public static void RemoveCart()
        {
            if (_cart.CartItems.Count > 0)
            {
                _cartItemsList.Clear();
            }
        }
    }
}
