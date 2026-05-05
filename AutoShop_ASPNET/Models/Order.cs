namespace AutoShop_ASPNET.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public DeliveryUserInfo DeliveryUserInfo { get; set; }
        public DateTime DateTimeCreation { get; set; }

        public decimal? TotalCost => CartItems?.Sum(item => item.ItemCost) ?? 0;

        public int? TotalQuantity => CartItems?.Sum(item => item.ItemQuantity) ?? 0;
    }
}
