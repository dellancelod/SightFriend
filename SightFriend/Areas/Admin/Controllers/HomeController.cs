using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SightFriend.Data.Repo;

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
            return View(dataManager.NewsItems.GetNews());
        }
    }
}
