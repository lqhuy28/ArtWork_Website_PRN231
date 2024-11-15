using AWS_BusinessObjects.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Persistence
{
    public class ApplicationDbContextInitialiser
    {
        private readonly ILogger<ApplicationDbContextInitialiser> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ApplicationDbContextInitialiser(ILogger<ApplicationDbContextInitialiser> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                if (_context.Database.IsSqlServer())
                {
                    await _context.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initialising the database.");
                throw;
            }
        }

        public async Task SeedAsync()
        {
            try
            {
                await TrySeedAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while seeding the database.");
                throw;
            }
        }

        public async Task TrySeedAsync()
        {

            // Roles
            //var roles = new List<IdentityRole>
            //{
            //    new IdentityRole("Admin"),
            //    new IdentityRole("Manager"),
            //    new IdentityRole("Customer"),
            //    new IdentityRole("Expert")
            //};
            //foreach (var role in roles)
            //{
            //    if (_roleManager.Roles.All(r => r.Name != role.Name))
            //    {
            //        await _roleManager.CreateAsync(role);
            //        _logger.LogInformation($"Role '{role.Name}' seeded successfully.");
            //    }
            //}

            // Default roles

            //AdministratorRole--------------------------------------------------------------------------------
            var administratorRole = new IdentityRole("Administrator");
            if (_roleManager.Roles.All(r => r.Name != administratorRole.Name))
            {
                await _roleManager.CreateAsync(administratorRole);
            }
            //Default AdministratorRole account
            var admin = new ApplicationUser { UserName = "admin@localhost", Email = "admin@localhost" };
            if (_userManager.Users.All(u => u.UserName != admin.UserName))
            {
                await _userManager.CreateAsync(admin, "Password@123");
                await _userManager.AddToRolesAsync(admin, new[] { administratorRole.Name });
            }
            //AdministratorRole--------------------------------------------------------------------------------

            //AudienceRole--------------------------------------------------------------------------------
            var audienceRole = new IdentityRole("Audience");
            if (_roleManager.Roles.All(r => r.Name != audienceRole.Name))
            {
                await _roleManager.CreateAsync(audienceRole);
            }
            //Default AudienceRole account
            var customer = new ApplicationUser { UserName = "audience@localhost", Email = "audience@localhost" };
            if (_userManager.Users.All(u => u.UserName != customer.UserName))
            {
                await _userManager.CreateAsync(customer, "Password@123");
                await _userManager.AddToRolesAsync(customer, new[] { audienceRole.Name });
            }
            //Default AudienceRole account
            var customer2 = new ApplicationUser { UserName = "audience2@localhost", Email = "audience2@localhost" };
            if (_userManager.Users.All(u => u.UserName != customer2.UserName))
            {
                await _userManager.CreateAsync(customer2, "Password@123");
                await _userManager.AddToRolesAsync(customer2, new[] { audienceRole.Name });
            }
            //Default AudienceRole account
            var customer3 = new ApplicationUser { UserName = "audience3@localhost", Email = "audience3@localhost" };
            if (_userManager.Users.All(u => u.UserName != customer3.UserName))
            {
                await _userManager.CreateAsync(customer3, "Password@123");
                await _userManager.AddToRolesAsync(customer3, new[] { audienceRole.Name });
            }
            //AudienceRole--------------------------------------------------------------------------------

            //ArtistRole--------------------------------------------------------------------------------
            var artistRole = new IdentityRole("Artist");
            if (_roleManager.Roles.All(r => r.Name != artistRole.Name))
            {
                await _roleManager.CreateAsync(artistRole);
            }
            //Default ArtistRole account
            var artist = new ApplicationUser { UserName = "artist@localhost", Email = "artist@localhost" };
            if (_userManager.Users.All(u => u.UserName != artist.UserName))
            {
                await _userManager.CreateAsync(artist, "Password@123");
                await _userManager.AddToRolesAsync(artist, new[] { artistRole.Name });
            }
            //Default ArtistRole account
            var artist2 = new ApplicationUser { UserName = "artist2@localhost", Email = "artist2@localhost" };
            if (_userManager.Users.All(u => u.UserName != artist2.UserName))
            {
                await _userManager.CreateAsync(artist2, "Password@123");
                await _userManager.AddToRolesAsync(artist2, new[] { artistRole.Name });
            }
            //Default ArtistRole account
            var artist3 = new ApplicationUser { UserName = "artist3@localhost", Email = "artist3@localhost" };
            if (_userManager.Users.All(u => u.UserName != artist3.UserName))
            {
                await _userManager.CreateAsync(artist3, "Password@123");
                await _userManager.AddToRolesAsync(artist3, new[] { artistRole.Name });
            }
            //ArtistRole--------------------------------------------------------------------------------


            await _context.SaveChangesAsync();
            // Default data
            /*// Seed, if necessary
            if (!_context.TodoLists.Any())
            {
                _context.TodoLists.Add(new TodoList
                {
                    Title = "Todo List",
                    Items =
                    {
                        new TodoItem { Title = "Make a todo list 📃" },
                        new TodoItem { Title = "Check off the first item ✅" },
                        new TodoItem { Title = "Realise you've already done two things on the list! 🤯"},
                        new TodoItem { Title = "Reward yourself with a nice, long nap 🏆" },
                    }
                });

                await _context.SaveChangesAsync();
            }*/
        }
    }
}
