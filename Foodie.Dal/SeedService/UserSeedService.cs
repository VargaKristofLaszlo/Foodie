using Foodie.Dal.Entities;
using Foodie.Dal.SeedInterfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodie.Dal.SeedService
{
    public class UserSeedService : IUserSeedService
    {
        private readonly UserManager<User> userManager;

        public UserSeedService(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public async Task SeedUserAsync()
        {


            if (!(await userManager.GetUsersInRoleAsync(Roles.Roles.Administrator)).Any())
            {
                var user = new User()
                {
                    Email = "admin@foodie.hu",
                    UserName = "admin",
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                var createResult = await userManager.CreateAsync(user, "Test.123");

                var addtoRoleResult = await userManager.AddToRoleAsync(user, Roles.Roles.Administrator);

                if (!createResult.Succeeded || !addtoRoleResult.Succeeded)
                {
                    throw new ApplicationException("Administrator could not be created" +
                        string.Join(", ", createResult.Errors.Concat(addtoRoleResult.Errors).Select(err => err.Description)));
                }
            }
        }
    }
}
