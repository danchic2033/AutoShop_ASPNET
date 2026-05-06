using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private Order _order;

        public Order GetOrders()
        {
            return _order;
        }
    }
}
