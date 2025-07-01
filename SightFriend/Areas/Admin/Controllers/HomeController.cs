using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SightFriend.Data;

namespace SightFriend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        private readonly UserManager<IdentityUser> userManager;
        public HomeController(DataManager dataManager, UserManager<IdentityUser> userManager) 
        {
            this.dataManager = dataManager;
            this.userManager = userManager;
        }
        public ActionResult Index()
        {
            ViewBag.MediaText = dataManager.TextFields.GetTextFieldByCodeWord("PageMedia").Title;
            ViewBag.NewsText = dataManager.TextFields.GetTextFieldByCodeWord("PageNews").Title;
            ViewBag.BooksText = dataManager.TextFields.GetTextFieldByCodeWord("PageBooks").Title;

            ViewBag.Users = userManager.Users.ToList(); // send user list to the view
            return View(dataManager);
        }
    }
}
