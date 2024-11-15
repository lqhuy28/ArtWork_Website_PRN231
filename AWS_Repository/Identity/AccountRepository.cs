using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_BusinessObjects.Identity;
using AWS_BusinessObjects.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Identity
{

    public class AccountRepository : IAccountRepository
    {
        private readonly IIdentityService identityService;
        private readonly IConfiguration configuration;
        private readonly RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private readonly IApplicationDbContext context;

        public AccountRepository(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            RoleManager<IdentityRole> roleManager,
            IIdentityService identityService,
            IApplicationDbContext context
            )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
            this.roleManager = roleManager;
            this.identityService = identityService;
            this.context = context;
        }
        public async Task<object> SignInAsync(SignInModel model)
        {
            /*var signInResult = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            if(!signInResult.Succeeded)
            {
                throw new InvalidOperationException("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại!");
                //return string.Empty;
            }*/
            var user = await identityService.GetUserByEmailAsync(model.Email);
         
            var passwordCheck = await userManager.CheckPasswordAsync(user, model.Password);
            if (user == null || passwordCheck == false)
            {
                throw new InvalidOperationException("Sai tên đăng nhập hoặc mật khẩu. Vui lòng thử lại!");
            }
            // Claims
            var authClaims = new List<Claim>
        {
            new Claim(ClaimTypes.Email, model.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };
            //Get role
            var userRole = await userManager.GetRolesAsync(user);
            foreach (var role in userRole)
            {
                //add role
                authClaims.Add(new Claim(ClaimTypes.Role, role.ToString()));
            }
            AccountModel accountModel = new AccountModel();
            foreach (var role in userRole)
            {
                if (role == "Administrator")
                {
                    accountModel = new AccountModel()
                    {
                        Email = user.Email,
                        Id = user.Id,
                        UserName = user.UserName,
                        isAdminAccount = true,
                        isArtistAccount = false,
                        isAudienceAccount = false,
                    };
                }
                else if (role == "Audience")
                {
                    accountModel = new AccountModel()
                    {
                        Email = user.Email,
                        Id = user.Id,
                        UserName = user.UserName,
                        isAdminAccount = false,
                        isArtistAccount = false,
                        isAudienceAccount = true,
                    };
                }
                else if (role == "Artist")
                {
                    accountModel = new AccountModel()
                    {
                        Email = user.Email,
                        Id = user.Id,
                        UserName = user.UserName,
                        isAdminAccount = false,
                        isArtistAccount = true,
                        isAudienceAccount = false,
                    };
                }
            }

            // Use this line to relax HMAC key size validation
            IdentityModelEventSource.ShowPII = true;

            // Get Key and token
            var authenKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:SecrectKey"]));
            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(30),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authenKey, SecurityAlgorithms.HmacSha512Signature)
            );

            // Return token

            return new { 
                token = new JwtSecurityTokenHandler().WriteToken(token),
                accinfo = accountModel
            };
        }

        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {
            var user = new ApplicationUser
            {
                Email = model.Email,
                UserName = model.Username,
                LockoutEnabled = false,
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                if (model.Status == AWS_BusinessObjects.Enums.SignUpStatus.AudienceAccount)
                {
                    if (!await roleManager.RoleExistsAsync("Audience"))
                    {
                        await roleManager.CreateAsync(new IdentityRole("Audience"));
                    }
                    await userManager.AddToRoleAsync(user, "Audience");
                }
                else if (model.Status == AWS_BusinessObjects.Enums.SignUpStatus.ArtistAccounts)
                {
                    if (!await roleManager.RoleExistsAsync("Artist"))
                    {
                        await roleManager.CreateAsync(new IdentityRole("Artist"));
                    }
                    await userManager.AddToRoleAsync(user, "Artist");
                }
                // Check role
            }

            return result;
        }

        public async Task<ApplicationUser> GetAccountByIdAsync(string id)
        {
            try
            {
                AWS_BusinessObjects.Identity.ApplicationUser user
                    = context.GetUser<ApplicationUser>().FirstOrDefault(r => r.Id == id);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<ApplicationUser>> GetAudienceAcountAsync()
        {
            try
            {
                List<AWS_BusinessObjects.Identity.ApplicationUser> users
                    = (List<ApplicationUser>)context.GetUser<ApplicationUser>().ToList();

                List<AWS_BusinessObjects.Identity.ApplicationUser> checkedUsers = new List<ApplicationUser>();
                foreach (var user in users)
                {
                    var isRole = await identityService.IsInRoleAsync(user.Id.ToString(), "AUDIENCE");
                    if (isRole)
                    {
                        checkedUsers.Add(user);
                    }
                }
                return checkedUsers;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<ApplicationUser>> GetArtistAcountAsync()
        {
            try
            {
                List<AWS_BusinessObjects.Identity.ApplicationUser> users
                    = (List<ApplicationUser>)context.GetUser<ApplicationUser>().ToList();

                List<AWS_BusinessObjects.Identity.ApplicationUser> checkedUsers = new List<ApplicationUser>();
                foreach (var user in users)
                {
                    var isRole = await identityService.IsInRoleAsync(user.Id.ToString(), "ARTIST");
                    if (isRole)
                    {
                        checkedUsers.Add(user);
                    }
                }
                return checkedUsers;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<List<ApplicationUser>> GetAdministratorAcountAsync()
        {
            try
            {
                List<AWS_BusinessObjects.Identity.ApplicationUser> users
                    = (List<ApplicationUser>)context.GetUser<ApplicationUser>().ToList();

                List<AWS_BusinessObjects.Identity.ApplicationUser> checkedUsers = new List<ApplicationUser>();
                foreach (var user in users)
                {
                    var isRole = await identityService.IsInRoleAsync(user.Id.ToString(), "ADMINISTRATOR");
                    if (isRole)
                    {
                        checkedUsers.Add(user);
                    }
                }
                return checkedUsers;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Lockout Enable Account
        public async Task<bool> LockoutEnableAccount(string email)
        {
            try
            {
                var user = await identityService.GetUserByEmailAsync(email);
                if (user == null)
                {
                    return false;
                }
                user.LockoutEnabled = true;
                user.LockoutEnd = DateTime.Now.AddYears(100);
                await userManager.UpdateAsync(user);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Lockout Disable Account
        public async Task<bool> LockoutDisableAccount(string email)
        {
            try
            {
                var user = await identityService.GetUserByEmailAsync(email);
                if (user == null)
                {
                    return false;
                }
                user.LockoutEnabled = false;
                user.LockoutEnd = null;
                await userManager.UpdateAsync(user);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
