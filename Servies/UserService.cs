using IdentityAspNetCore.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace IdentityAspNetCore.Servies
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
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
    }
}
