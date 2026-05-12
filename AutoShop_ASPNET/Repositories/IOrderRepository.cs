using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        void AddOrder(Order order);
    }
}