using Microsoft.AspNetCore.Identity;
using MyApiNetCore6.Models;

namespace MyApiNetCore6.Repositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);
    }
}
