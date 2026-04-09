using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public class InMemoryFavoriteRepository : IFavoriteRepository
    {
        private Favorite _favorite;

        public void AddItemToFavorite(Product product)
        {
            if (_favorite != null)
            {
                var existingCart = _favorite.Product.FirstOrDefault(item =>  item.Id == product.Id);

                if (existingCart == null)
                {
                    _favorite.Product.Add(product);
                }
            }

            if (_favorite == null)
            {
                _favorite = new Favorite
                {
                    Product = new List<Product>()
                };
                _favorite.Product.Add(product);
            }
        }

        public void RemoveItemFromFavorite(Product product)
        {
            var existingCart = _favorite.Product.FirstOrDefault(item => item.Id == product.Id);

            if (existingCart != null)
            {
                for (int i = 0; i < _favorite.Product.Count; i++)
                {
                    if (product.Id == _favorite.Product[i].Id)
                    {
                        _favorite.Product.RemoveAt(i);
                    }
                }
            }
        }

        public Favorite GetFavoriteItem()
        {
            return _favorite;
        }

        public void ClearFavoriteCatalog()
        {
            _favorite.Product.Clear();
        }
    }
}
