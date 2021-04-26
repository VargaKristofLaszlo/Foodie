using Foodie.Dal.SeedInterfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Foodie.Dal.SeedService
{
    public class RoleSeedService : IRoleSeedService
    {
        private readonly RoleManager<IdentityRole<int>> roleManager;

        public RoleSeedService(RoleManager<IdentityRole<int>> roleManager)
        {
            this.roleManager = roleManager;
        }

        public async Task SeedRoleAsync()
        {
            if( !await roleManager.RoleExistsAsync(Roles.Roles.Administrator)) 
            {
                await roleManager.CreateAsync(new IdentityRole<int> {Name = Roles.Roles.Administrator });
            }
            if (!await roleManager.RoleExistsAsync(Roles.Roles.User))
            {
                await roleManager.CreateAsync(new IdentityRole<int> { Name = Roles.Roles.User });
            }
        }
    }
}
