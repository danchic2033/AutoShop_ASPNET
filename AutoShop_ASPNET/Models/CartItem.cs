namespace AutoShop_ASPNET.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemCost { get; set; }
    }
}
