using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IFavoriteRepository _favoriteRepository;
        private readonly IProductsRepository _productsRepository;
        public FavoriteController(IFavoriteRepository favoriteRepository, IProductsRepository productsRepository)
        {
            _favoriteRepository = favoriteRepository;
            _productsRepository = productsRepository;
        }
        public IActionResult Index()
        {
            var favoriteList = _favoriteRepository.GetFavoriteItem();

            return View(favoriteList);
        }

        public IActionResult AddToFavorite(int id)
        {
            var product = _productsRepository.TryGetById(id);

            _favoriteRepository.AddItemToFavorite(product);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult RemoveFromFavorite(int id)
        {
            var product = _productsRepository.TryGetById(id);

            _favoriteRepository.RemoveItemFromFavorite(product);

            return RedirectToAction("Index", "Favorite");
        }

        public IActionResult ClearFavorite()
        {

            _favoriteRepository.ClearFavoriteCatalog();

            return RedirectToAction("Index", "Favorite");
        }
    }
}
