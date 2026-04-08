using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public class InMemoryFavoriteRepository : IFavoriteRepository
    {
        private readonly Favorite _favorite;

        public void AddItemToFavorite(Product product)
        {
            //Нужно взять логику из класса Home
            if (_favorite != null)
            {
                var existingCart = _favorite.Product.

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

        public void RemoveItemFromFavorite(Product product)
        {
            var existingCart = _favorite.Products.FirstOrDefault(item => item.Id == product.Id);

            //Дописать условие, чтобы при удалении продукта не выходить за границы

            if (existingCart != null)
            {
                for (int i = 0; i < _favorite.Products.Count; i++)
                {
                    if (product.Id == _favorite.Products[i].Id)
                    {
                        _favorite.Products.RemoveAt(i);
                    }
                }
            }
        }

        public Favorite GetFavoriteItem()
        {
            return _favorite;
        }
    }
}
