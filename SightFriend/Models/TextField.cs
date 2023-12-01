using System.ComponentModel.DataAnnotations;

namespace SightFriend.Models
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }
        [Display(Name = "Назва розділу")]
        public string Title { get; set; } = "Інформаційна сторінка";
        [Display(Name = "Вміст сторінки")]
        public string Text { get; set; } = "Вміст заповнюється адміністратором";
        
    }
}
