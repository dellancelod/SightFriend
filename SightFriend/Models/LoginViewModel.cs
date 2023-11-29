using System.ComponentModel.DataAnnotations;

namespace SightFriend.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="Введіть номер телефону")]
        [Display(Name = "Номер телефону")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Введіть пароль")]
        [UIHint("Введіть пароль")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

    }
}
