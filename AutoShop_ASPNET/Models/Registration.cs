using System.ComponentModel.DataAnnotations;

namespace AutoShop_ASPNET.Models
{
    public class Registration
    {
        [Display(Name = "Имя", Prompt ="Иван")]
        [Required(ErrorMessage = "Напишите ваше имя")]
        public string Name { get; set; }

        [Display(Name = "Логин", Prompt = "Введите логин")]
        [Required(ErrorMessage = "Укажите почту")]
        [EmailAddress(ErrorMessage = "Введите корректную почту")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Длина логина должна быть от {2} до {1} символов")]
        public string Login { get; set; }

        [Display(Name = "Пароль", Prompt = "Введите пароль")]
        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Длина пароля должна быть от {2} до {1} символов")]
        public string Password { get; set; }

        [Display(Name = "Пароль", Prompt = "Повторите пароль")]
        [Required(ErrorMessage = "Нужно повторить пароль")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Длина пароля должна быть от {2} до {1} символов")]
        [Compare("Password", ErrorMessage = "Пароли должны совпадать")]
        public string ConfirmPassword { get; set; }
    }
}
