using IdentityAspNetCore.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace IdentityAspNetCore.Servies
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUserAync(RegisterViewModel model);
    }
}
