namespace AutoShop_ASPNET.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; } 
        public decimal Cost { get; set; }
        public string? Description { get; set; }

        //при создании объекта Name класса Product обязательно нужно инициализировать Name.
        //На это указывается required

        public override string ToString()
        {
            return $"{Id}{Environment.NewLine}{Name}{Environment.NewLine}{Cost:c}{Environment.NewLine}";
        }
    }
}
