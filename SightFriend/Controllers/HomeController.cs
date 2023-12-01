using Microsoft.AspNetCore.Mvc;
using SightFriend.Data;
using SightFriend.Models;
using System.Diagnostics;

namespace SightFriend.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataManager dataManager)
        {
            _logger = logger;
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                ViewBag.Cabinet = "Особистий кабінет\n" + HttpContext.User.Identity.Name;
            }
            else
            {
                ViewBag.Cabinet = "Авторизація";
            }
            ViewBag.MediaText = dataManager.TextFields.GetTextFieldByCodeWord("PageMedia").Title;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult RadioPartial()
        {
            return PartialView("_Radio");
        }

        public IActionResult InfoPartial()
        {
            return PartialView("_Info");
        }

        public IActionResult ColorBlindPartial()
        {
            return PartialView("_ColorBlind");
        }
    }
}