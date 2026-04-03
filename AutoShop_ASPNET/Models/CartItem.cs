namespace AutoShop_ASPNET.Models
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemCost => Product.Cost * ItemQuantity;
    }
}
