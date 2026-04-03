namespace AutoShop_ASPNET.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
        public decimal TotalCost => CartItems.Sum(item => item.ItemCost);

        public Cart (List<CartItem> cartItems)
        {
            CartItems = cartItems;
        }
    }
}
