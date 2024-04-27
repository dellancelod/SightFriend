using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SightFriend.Models
{
    public class BookItem : EntityBase
    {
        [Required(ErrorMessage = "Заповніть назву")]
        [Remote(action: "IsTitleAvailable", controller: "BookItems", ErrorMessage = "Назва вже існує")]
        public string Title { get; set; } = "Заголовок";
        [Required(ErrorMessage = "Заповніть автора")]
        public string Author { get; set; } = "Автор";
        [Required(ErrorMessage = "Вставте аудіофайл")]
        public string AudioFilePath { get; set; } = "Аудіо-Книга";
        public string CoverImagePath { get; set; } = "Обкладинка";
        public string Length { get; set; } = "Тривалість";
        public bool Hidden { get; set; }
    }
}
