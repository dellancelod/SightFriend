using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SightFriend.Data;
using SightFriend.Models;
using SightFriend.Services;
using System.Text;

namespace SightFriend.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")] // Доступ лише адміністраторам
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        public UsersController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Edit(Guid id)
        {

            var model = new User();

            if (id != default)
            {

                var user = await userManager.FindByIdAsync(id.ToString());
                model = new User
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber
                };
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User model)
        {
            if (ModelState.IsValid)
            {
                var phoneNumber = NormalizePhoneNumber(model.PhoneNumber);
                var user = new IdentityUser
                {
                    UserName = model.UserName,
                    PhoneNumber = phoneNumber,
                    PhoneNumberConfirmed = true,
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    // За замовчуванням додамо роль "user" (можна змінити)
                    await userManager.AddToRoleAsync(user, "user");

                    return RedirectToAction("Index", "Home", new { area = "Admin" }); // або куди потрібно
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var user = await userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (string.IsNullOrEmpty(id))
                return NotFound();

            var user = await userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound();

            var result = await userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" }); // redirect to user list or wherever you want
            }
            else
            {
                // Show errors
                foreach (var error in result.Errors)
                    ModelState.AddModelError("", error.Description);
                return View(user);
            }
        }

        public virtual string NormalizePhoneNumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";

            var result = new StringBuilder();
            for (int i = 3; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                    result.Append(input[i]);
            }

            return result.ToString();
        }
    }
}
