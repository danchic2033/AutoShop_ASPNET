using System.ComponentModel.DataAnnotations;

namespace AutoShop_ASPNET.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Название товара", Prompt = "Введите название товара")]
        [Required(ErrorMessage = "Нужно ввести название товара")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Длина названия должна быть от {2} до {1} символов")]
        public required string Name { get; set; }

        [Display(Name = "Стоимость товара", Prompt = "Введите стоимость товара")]
        [Required(ErrorMessage = "Нужно ввести стоимость товара")]
        [StringLength(1000000, MinimumLength = 0, ErrorMessage = "Стоимость товара должна быть от {2} до {1} рублей")]
        public decimal Cost { get; set; }

        [Display(Name = "Описание", Prompt = "Введите описание товара")]
        [StringLength(4096, ErrorMessage = "Описание товара должна быть до {1} символов")]
        public string? Description { get; set; }
    }
}
