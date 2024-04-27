using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SightFriend.Data;
using SightFriend.Models;

namespace SightFriend.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        public BookItemsController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }

        //One view for Adding and Editing
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new BookItem() : dataManager.BooksItems.GetBookItemById(id);
            return View(entity);
        }
        [HttpPost]
        [RequestSizeLimit(512 * 1024 * 1024)]
        public IActionResult Edit(BookItem model, IFormFile audioBookFile, IFormFile coverImageFile)
        {
            if (ModelState.IsValid)
            {
                if (audioBookFile != null)
                {
                    if (audioBookFile.Length > 512 * 1024 * 1024)
                    {
                        ModelState.AddModelError("audioBookFile", "Розмір аудіофайлу перевищує 512Мб!");
                        return View(model);
                    }

                    model.AudioFilePath = audioBookFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, "audio-books/", audioBookFile.FileName), FileMode.Create))
                    {
                        audioBookFile.CopyTo(stream);
                    }
                }

                if (coverImageFile != null)
                {
                    if (coverImageFile.Length > 512 * 1024 * 1024)
                    {
                        ModelState.AddModelError("audioBookFile", "Розмір обкладинки перевищує 512Мб!");
                        return View(model);
                    }

                    model.CoverImagePath = coverImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, "bookcovers/", coverImageFile.FileName), FileMode.Create))
                    {
                        coverImageFile.CopyTo(stream);
                    }
                }

                dataManager.BooksItems.SaveBookItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.BooksItems.DeleteBookItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
        }


    }
}
