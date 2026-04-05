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

        public void RemoveItemFromCart(Product product)
        {
            var existingCart = _cart.CartItems.FirstOrDefault(item => item.Product == product);

            //Дописать условие, чтобы при удалении продукта не выходить за границы

            if (_cart.CartItems[product.Id - 1].ItemQuantity == 1 && existingCart != null)
            {
                for (int i = 0; i < _cart.CartItems.Count; i++)
                {
                    if (product.Id == _cart.CartItems[i].Product.Id)
                    {
                        _cart.CartItems.RemoveAt(i);
                    }
                }
            }
            else
            {
                _cart.CartItems[product.Id - 1].ItemQuantity--;
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
