using System.ComponentModel.DataAnnotations;

namespace AutoShop_ASPNET.Models
{
    public enum OrderStatus
    {
        [Display(Name = "Создан")]
        Created,

        [Display(Name = "Обработка")]
        Processed,

        [Display(Name = "В пути")]
        Delivering,

        [Display(Name = "Доставлен")]
        Delivered,

        [Display(Name = "Отменен")]
        Canceled
    }
}
