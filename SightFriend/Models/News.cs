using System.ComponentModel.DataAnnotations;

namespace SightFriend.Models
{
    public class News : EntityBase
    {
        public string Title { get; set; }
        [Display(Name = "Опис")]
        public string Subitle { get; set; }
        [Display(Name = "Зміст")]
        public string Text { get; set; }

    }
}
