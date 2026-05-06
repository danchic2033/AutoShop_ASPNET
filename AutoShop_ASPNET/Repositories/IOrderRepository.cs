using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public interface IOrderRepository
    {
        Order GetOrders();
    }
}