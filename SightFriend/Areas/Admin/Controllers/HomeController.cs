using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SightFriend.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
