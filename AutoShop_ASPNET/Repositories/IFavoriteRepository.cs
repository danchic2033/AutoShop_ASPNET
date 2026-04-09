using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public interface IFavoriteRepository
    {
        void ClearFavoriteCatalog();
        void RemoveItemFromFavorite(Product product);
        void AddItemToFavorite(Product product);
        Favorite GetFavoriteItem();
    }
}