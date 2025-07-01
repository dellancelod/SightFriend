using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SightFriend.Models;
using SightFriend.Services;

namespace SightFriend.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly CustomUserManager userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public AccountController(CustomUserManager userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login(string? returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByPhoneNumberAsync(model.PhoneNumber);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, true, false);
                    if (result.Succeeded)
                    {
                        bool isAdmin = await userManager.IsInRoleAsync(user, "Admin");
                        if (isAdmin)
                        {
                            return RedirectToAction("Index", "Admin");
                        }

                        return Redirect(returnUrl ?? "/");
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.PhoneNumber), "Невірний номер телефону або пароль");
            }
            return View(model);
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Index()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return Redirect("Login");
            }
            var user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                bool isAdmin = await userManager.IsInRoleAsync(user, "Admin");
                if (isAdmin)
                {
                    return RedirectToAction("Index", "Admin");
                }

                ViewBag.Username = user.UserName;
            }

            ViewBag.Username = HttpContext.User.Identity.Name;
            return View();
        }
    }
}
