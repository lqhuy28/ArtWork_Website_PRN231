using AWS_BusinessObjects.Identity;
using AWS_BusinessObjects.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Identity
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<object> SignInAsync(SignInModel model);
        public Task<ApplicationUser> GetAccountByIdAsync(string id);
        public Task<List<ApplicationUser>> GetAudienceAcountAsync();
        public Task<List<ApplicationUser>> GetArtistAcountAsync();
        public Task<List<ApplicationUser>> GetAdministratorAcountAsync();
        public Task<bool> LockoutEnableAccount(string email);
        public Task<bool> LockoutDisableAccount(string email);
    }
}
