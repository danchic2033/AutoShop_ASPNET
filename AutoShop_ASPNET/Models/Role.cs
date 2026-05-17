using System.ComponentModel.DataAnnotations;

namespace AutoShop_ASPNET.Models
{
    public class Role
    {
        [Display(Name = "Имя", Prompt = "Введите название роли")]
        [Required(ErrorMessage = "Необходимо ввести название роли")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от {2} до {1} символов")]
        public string Name { get; set; }
    }
}
