using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SightFriend.Data;

namespace SightFriend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager) 
        {
            this.dataManager = dataManager;
        }
        public ActionResult Index()
        {
            ViewBag.MediaText = dataManager.TextFields.GetTextFieldByCodeWord("PageMedia").Title;
            ViewBag.NewsText = dataManager.TextFields.GetTextFieldByCodeWord("PageNews").Title;
            ViewBag.BooksText = dataManager.TextFields.GetTextFieldByCodeWord("PageBooks").Title;
            return View(dataManager);
        }
    }
}
