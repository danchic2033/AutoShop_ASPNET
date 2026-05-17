using AutoShop_ASPNET.Models;

namespace AutoShop_ASPNET.Repositories
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private List<Order> _order;

        public List<Order> GetOrders()
        {
            return _order;
        }

        public void AddOrder(Order order)
        {
            if (_order == null)
            {
                _order = new List<Order>();
            }
            _order.Add(order);
        }

        public void UpdateStatus(Guid orderId, OrderStatus status)
        {
            var existingOrder = TryGetById(orderId);

            if (existingOrder != null)
            {
                existingOrder.Status = status;
            }
        }

        public Order TryGetById(Guid orderId)
        {
            return _order.FirstOrDefault(o => o.Id == orderId);
        }
    }
}
