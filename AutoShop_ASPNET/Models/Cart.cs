namespace AutoShop_ASPNET.Models
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; }

        public Cart (List<CartItem> cartItems)
        {
            CartItems = cartItems;
        }
    }
}
