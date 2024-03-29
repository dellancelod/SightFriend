﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SightFriend.Data;
using SightFriend.Models;

namespace SightFriend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsItemsController : Controller
    {
        private readonly DataManager dataManager;
        public NewsItemsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        //One view for Adding and Editing
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new NewsItem() : dataManager.NewsItems.GetNewsItemById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(NewsItem model)
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
