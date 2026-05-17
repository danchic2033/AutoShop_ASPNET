using AutoShop_ASPNET.Models;
using AutoShop_ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop_ASPNET.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IRoleRepository _roleRepository;
        public AdminController(IProductsRepository productsRepository, IOrderRepository orderRepository, IRoleRepository roleRepository)
        {
            _productsRepository = productsRepository;
            _orderRepository = orderRepository;
            _roleRepository = roleRepository;
        }
        public IActionResult Index()
        {
            var orders = _orderRepository.GetOrders();

            return View(orders);
        }

        public IActionResult UpdateOrderStatus(Guid orderId, OrderStatus status)
        {
            _orderRepository.UpdateStatus(orderId, status);
            return RedirectToAction(nameof(Index));
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

        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRole(Role role)
        {
            if (_roleRepository.TryGetByName(role.Name) != null)
            {
                ModelState.AddModelError("", "Такая роль уже существует!");
            }

            if (!ModelState.IsValid)
            {
                return View(role);
            }

            _roleRepository.Add(role);

            return RedirectToAction(nameof(Roles));
        }

        public IActionResult DeleteRole(Guid roleId)
        {
            _roleRepository.Remove(roleId);

            return RedirectToAction(nameof(Roles));
        }

        public IActionResult Roles()
        {
            var roles = _roleRepository.GetAll();
            return View(roles);
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
