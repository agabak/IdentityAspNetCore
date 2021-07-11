using IdentityAspNetCore.Models;
using IdentityAspNetCore.Servies;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IdentityAspNetCore.Controllers.Accounts
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var result = await _userService.RegisterUserAync(model);
            if(result.Succeeded)
            {
                return View();
            }
            return View();
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }
    }
}
