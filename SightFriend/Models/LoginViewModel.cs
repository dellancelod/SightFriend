using System.ComponentModel.DataAnnotations;

namespace SightFriend.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Номер телефону")]
        public string PhoneNumber { get; set; }

        [Required]
        [UIHint("Введіть пароль")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

    }
}
