using IdentityAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IdentityAspNetCore.Controllers.Accounts
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            return View();
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }
    }
}
