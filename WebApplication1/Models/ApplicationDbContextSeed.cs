using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedRoleAsync(RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdminRole));
            await roleManager.CreateAsync(new IdentityRole(Roles.AdminRole));
            await roleManager.CreateAsync(new IdentityRole(Roles.ModeradorRole));
            await roleManager.CreateAsync(new IdentityRole(Roles.AlumnoRole));
        }

        public static async Task SeedSuperAdminAsync(UserManager<IdentityUser> userManager)
        {
            var userAdmin = userManager.Users.Where(u => u.Email == Roles.MailSuperAdmin).FirstOrDefault();
            //Verificamos si ya existe el usuario
            if (userAdmin != null)
            {
                return;
            }

            //Creamos Usuario SuperAmin
            userAdmin = new IdentityUser
            {
                UserName = Roles.MailSuperAdmin,
                Email = Roles.MailSuperAdmin,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            await userManager.CreateAsync(userAdmin, "Super123");
            await userManager.AddToRoleAsync(userAdmin, Roles.SuperAdminRole);

        }
    }
}
