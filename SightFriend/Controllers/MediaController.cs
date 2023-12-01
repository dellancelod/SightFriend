using Microsoft.AspNetCore.Mvc;
using SightFriend.Data;

namespace SightFriend.Controllers
{
    public class MediaController : Controller
    {
        private readonly DataManager dataManager;
        public MediaController(DataManager dataManager) 
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            ViewBag.NewsText = dataManager.TextFields.GetTextFieldByCodeWord("PageNews").Title;
            ViewBag.BooksText = dataManager.TextFields.GetTextFieldByCodeWord("PageBooks").Title;
            return View();
        }
    }
}
