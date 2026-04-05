using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public class InMemoryCartRepository : ICartRepository
    {
        private Cart _cart;

        public void AddItemToCart(Product product)
        {
            var cartItem = new CartItem();
            cartItem.Product = product;
            cartItem.ItemQuantity = 1;

            if (_cart != null)
            {
                var existingCart = _cart.CartItems.FirstOrDefault(item => item.Product == cartItem.Product);

                if (existingCart != null)
                {
                    for (int i = 0; i < _cart.CartItems.Count; i++)
                    {
                        if (_cart.CartItems[i].Product == cartItem.Product)
                        {
                            _cart.CartItems[i].ItemQuantity++;
                            break;
                        }
                    }
                }

                if (existingCart == null && _cart != null)
                {
                    _cart.CartItems.Add(cartItem);
                }
            }

            if (_cart == null)
            {
                _cart = new Cart();
                _cart.Id = Guid.NewGuid();
                _cart.UserId = Constants.UserId;
                _cart.CartItems.Add(cartItem);
            }
        }

        public void RemoveItemFromCart(int id)
        {
            for (int i = 0; i < _cart.CartItems.Count; i++)
            {
                if (id == i)
                {
                    _cart.CartItems.RemoveAt(i);
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
                _cart.CartItems.Clear();
            }
        }
    }
}
