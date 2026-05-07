using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrders();
        void AddOrder(Order order);
    }
}