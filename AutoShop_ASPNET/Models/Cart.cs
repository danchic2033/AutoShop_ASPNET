namespace AutoShop_ASPNET.Models
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; }
        public decimal CartCost { get; set; }
    }
}
