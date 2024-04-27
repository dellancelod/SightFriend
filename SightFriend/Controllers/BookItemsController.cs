using Microsoft.AspNetCore.Mvc;
using SightFriend.Data;
using SightFriend.Models;

namespace SightFriend.Controllers
{
    public class BookItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        public BookItemsController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.BooksItems.GetBookItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageBooks");
            return View(dataManager.BooksItems.GetBookItems());
        }
    }
}