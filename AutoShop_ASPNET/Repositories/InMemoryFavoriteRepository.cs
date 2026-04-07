using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public class InMemoryFavoriteRepository : IFavoriteRepository
    {
        private readonly Favorite _favorite;

        public void AddItemToFavorite(Product product)
        {

            if (_favorite != null)
            {
                var existingCart = _favorite.Products.FirstOrDefault(item => item.Id == product.Id);

                if (existingCart != null)
                {
                    for (int i = 0; i < _favorite.Products.Count; i++)
                    {
                        if (_favorite.Products[i].Id == product.Id)
                        {
                            break;
                        }
                    }
                }

                if (existingCart == null && _favorite != null)
                {
                    _favorite.Products.Add(product);
                }
            }

            if (_favorite == null)
            {
                _favorite.Products.Add(product);
            }
        }

        //public void RemoveItemFromFavorite(Product product)
        //{
        //    var existingCart = _cart.CartItems.FirstOrDefault(item => item.Product == product);

        //    //Дописать условие, чтобы при удалении продукта не выходить за границы

        //    if (_cart.CartItems[product.Id - 1].ItemQuantity == 1 && existingCart != null)
        //    {
        //        for (int i = 0; i < _cart.CartItems.Count; i++)
        //        {
        //            if (product.Id == _cart.CartItems[i].Product.Id)
        //            {
        //                _cart.CartItems.RemoveAt(i);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        _cart.CartItems[product.Id - 1].ItemQuantity--;
        //    }
        //}

        public Favorite GetFavoriteItem()
        {
            return _favorite;
        }
    }
}
