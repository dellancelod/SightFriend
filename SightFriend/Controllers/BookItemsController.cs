using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SightFriend.Data;
using SightFriend.Models;
using System.Drawing.Printing;

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
        public IActionResult Index(Guid id, int page = 1, int pageSize = 10)
        {
            if (id != default)
            {
                return View("Show", dataManager.BooksItems.GetBookItemById(id));
            }

            var model = dataManager.BooksItems.GetBookItems()
                .Where(x => !x.Hidden)
                .OrderByDescending(x => x.DateAdded)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageBooks");
            return View(model);
        }
    }
}