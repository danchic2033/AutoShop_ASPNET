using AutoShop_ASPNET.Helpers;
using System.ComponentModel.DataAnnotations;

namespace AutoShop_ASPNET.Models
{
    public class DeliveryUserInfo
    {
        [Display(Name = "Имя", Prompt = "Введите имя")]
        [Required(ErrorMessage = "Нужно ввести имя")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от {2} до {1} символов")]
        public string Name { get; set; }

        [Display(Name = "Адрес доставки", Prompt = "Введите адрес доставки")]
        [Required(ErrorMessage = "Нужно ввести адрес доставки")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Длина адреса должна быть от {2} до {1} символов")]
        public string Address { get; set; }

        [Display(Name = "Номер телефона", Prompt = "Введите номер телефона")]
        [Required(ErrorMessage = "Нужно ввести номер телефона")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Введите корректный номер телефона")]
        [StringLength(16, MinimumLength = 5, ErrorMessage = "Длина номера телефона должна быть от {2} до {1} символов")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Дата доставки", Prompt = "Введите дату доставки")]
        [Required(ErrorMessage = "Нужно ввести дату доставки")]
        [DataType(DataType.Date)]
        [DateRange]
        public string DateDelivery { get; set; }

        [Display(Name = "Комментарий к заказу", Prompt = "Напишите комментарий, если нужно сообщить деатали курьеру")]
        [StringLength(512)]
        public string? Comment { get; set; }
    }
}
