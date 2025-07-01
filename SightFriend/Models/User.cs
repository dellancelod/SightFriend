using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SightFriend.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Введіть ПІБ користувача")]
        [Display(Name = "ПІБ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введіть телефон")]
        [Phone(ErrorMessage = "Некоректний номер телефону")]
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Введіть пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
