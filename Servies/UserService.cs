using IdentityAspNetCore.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace IdentityAspNetCore.Servies
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppUser> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public UserService(
            UserManager<AppUser> userManager,
            RoleManager<AppUser> roleManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> RegisterUserAync(RegisterViewModel model)
        {
            if (model is null) return null;
            AppUser user = new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                DateOfBorn = DateTime.Now,
                LastDateLogin = DateTime.Now,
                Email = model.Email,
                UserName = model.Email
            };

            return await _userManager.CreateAsync(user, model.Password);
        }

        public async Task<SignInResult> LoginUserAsync(LoginViewModel model, AppUser user)
        {
           if (model is null) return null;
           return await _signInManager
          .PasswordSignInAsync(user, model.Password, model.RememberMe, false);
        }
    }
}
