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

        public void AddOrder(Order order)
        {
            if (_order == null)
            {
                _order = new Order();
            }
            _order = order;
        }
    }
}
