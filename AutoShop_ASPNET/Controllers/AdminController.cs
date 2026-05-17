using AutoShop_ASPNET.Models;
using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IOrderRepository _orderRepository;
        public AdminController(IProductsRepository productsRepository, IOrderRepository orderRepository)
        {
            _productsRepository = productsRepository;
            _orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            var orders = _orderRepository.GetOrders();

            return View(orders);
        }
        public IActionResult OrderInformation(Guid orderId)
        {
            var order = _orderRepository.TryGetById(orderId);

            return View(order);
        }

        public IActionResult Users()
        {
            return View();
        }
        public IActionResult Roles()
        {
            return View();
        }
        public IActionResult Products()
        {
            var products = _productsRepository.GetAll();

            return View(products);
        }

        public IActionResult RemoveItem(int id)
        {
            _productsRepository.RemoveItemById(id);

            return RedirectToAction("Products");
        }

        public IActionResult EditItem(int id)
        {
            var product = _productsRepository.TryGetById(id);

            return View(product);
        }

        public IActionResult SaveItem(Product product)
        {
            var productEdit = _productsRepository.TryGetById(product.Id);

            if (productEdit != null)
            {
                productEdit.Name = product.Name;
                productEdit.Description = product.Description;
                productEdit.Cost = product.Cost;
            }
            else
            {
                _productsRepository.AddItem(product);
            }

            return RedirectToAction("Products");
        }

        public IActionResult CreateItem()
        {
            var products = _productsRepository.GetAll();

            var lastProduct = products.TakeLast(1).FirstOrDefault();

            return View(lastProduct);
        }
    }
}
