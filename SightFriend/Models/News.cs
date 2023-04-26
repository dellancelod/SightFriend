using System.ComponentModel.DataAnnotations;

namespace SightFriend.Models
{
    public class News
    {
        private News() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }
        [Display(Name = "Заголовок")]
        public string Title { get; set; }
        [Display(Name = "Опис")]
        public string Subitle { get; set; }
        [Display(Name = "Зміст")]
        public string Text { get; set; }
        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

    }
}
