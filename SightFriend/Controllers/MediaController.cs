using Microsoft.AspNetCore.Mvc;

namespace SightFriend.Controllers
{
    public class MediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
