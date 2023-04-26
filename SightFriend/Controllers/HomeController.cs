using Microsoft.AspNetCore.Mvc;
using SightFriend.Models;
using System.Diagnostics;

namespace SightFriend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public IActionResult LoginPartial()
        {
            return PartialView("_Login");
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