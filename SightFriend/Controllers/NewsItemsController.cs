using Microsoft.AspNetCore.Mvc;
using SightFriend.Data;
using SightFriend.Models;

namespace SightFriend.Controllers
{
    [Area("Admin")]
    public class NewsItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        public NewsItemsController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            NewsItem entity = id == default ? new NewsItem() : dataManager.NewsItems.GetNewsItemById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(NewsItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                dataManager.NewsItems.SaveNewsItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.NewsItems.DeleteNewsItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
        }

    }
}
