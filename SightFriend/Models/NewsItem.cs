using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SightFriend.Models
{
    public class NewsItem : EntityBase
    {
        [Required(ErrorMessage = "Заповніть заголовок новини")]
        [Remote(action: "IsTitleAvailable", controller: "NewsItems", ErrorMessage = "Заголовок вже існує")]
        public string Title { get; set; } = "Заголовок";
        [Display(Name = "Опис")]
        public string Subtitle { get; set; }
        [Display(Name = "Зміст")]
        public string Text { get; set; } = "Вміст заповнюється адміністратором";

    }
}
