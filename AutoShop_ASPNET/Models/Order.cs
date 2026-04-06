namespace AutoShop_ASPNET.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
