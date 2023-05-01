using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SightFriend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
