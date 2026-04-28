using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class CompareController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        private readonly ICompareRepository _compareRepository;
        public CompareController(IProductsRepository productsRepository, ICompareRepository compareRepository)
        {
            _productsRepository = productsRepository;
            _compareRepository = compareRepository;
        }
        public IActionResult Index()
        {
            var products = _compareRepository.GetCompare();
            return View(products);
        }
        //public IActionResult RemoveFromCompare(int id)
        //{
        //    _compareRepository.RemoveItemFromCompare();

        //    return RedirectToAction("Index", products);
        //}

        public IActionResult AddToCompare(int id)
        {
            var products = _productsRepository.TryGetById(id);

            return RedirectToAction("Index", products);
        }
    }
}
