using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using System.Text.RegularExpressions;

namespace OnlineConsultations.Common
{
    public static class ManageRoles
    {
        public static IApplicationBuilder SeedUsersRoles(this IApplicationBuilder applicationBuilder)
        {
            using var scopedServices = applicationBuilder.ApplicationServices.CreateScope();

            var services = scopedServices.ServiceProvider;
             
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();
            var applicationUserService = services.GetRequiredService<IApplicationUserService>();

            CreateRoles(roleManager);
            AssignUsers(userManager, applicationUserService);

            return applicationBuilder;
        }

        private static void CreateRoles(RoleManager<ApplicationRole> roleManager)
        {
            Task
                 .Run(async () =>
                 {
                     if (await roleManager.RoleExistsAsync("Admin") == false)
                     {
                         var roleToBeCreated = new ApplicationRole()
                         {
                             Name = "Admin"
                         };

                         var resultCreateRole = await roleManager.CreateAsync(roleToBeCreated);
                     }
                 })
                 .GetAwaiter()
                 .GetResult();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync("ProvideUser") == false)
                    {
                        var roleToBeCreated = new ApplicationRole()
                        {
                            Name = "ProvideUser"
                        };

                        var resultCreateRole = await roleManager.CreateAsync(roleToBeCreated);
                    }
                })
                .GetAwaiter()
                .GetResult();

            Task
               .Run(async () =>
               {
                   if (await roleManager.RoleExistsAsync("SearchUser") == false)
                   {
                       var roleToBeCreated = new ApplicationRole()
                       {
                           Name = "SearchUser"
                       };

                       var resultCreateRole = await roleManager.CreateAsync(roleToBeCreated);
                   }
               })
               .GetAwaiter()
               .GetResult();
        }

        private static void AssignUsers(UserManager<ApplicationUser> userManager, IApplicationUserService applicationUserService)
        {
            Task
                 .Run(async () =>
                 {
                     var userToBeAssigned = new ApplicationUser();

                     if (await userManager.FindByNameAsync("admin@admin.com") == null)
                     {
                         userToBeAssigned.UserName = "admin@admin.com";
                         userToBeAssigned.Email = "admin@admin.com";

                         var resultFromCreatingUser = await userManager.CreateAsync(userToBeAssigned, "Admin123");

                         if (resultFromCreatingUser.Succeeded)
                         {
                             await userManager.AddToRoleAsync(userToBeAssigned, "Admin");
                         }
                     }
                     else
                     {
                         userToBeAssigned = await userManager.FindByEmailAsync("admin@admin.com");
                         await userManager.AddToRoleAsync(userToBeAssigned, "Admin");
                     }
                 })
                 .GetAwaiter()
                 .GetResult();

            Task
                 .Run(async () =>
                 {
                     var userToBeAssigned = new ApplicationUser();

                     if (applicationUserService.GetApplicationUsers() == null)
                     {
                         var applicationUsers = applicationUserService.GetApplicationUsers();

                         foreach (var applicationUser in applicationUsers.Result)
                         {
                             if (Regex.IsMatch(applicationUser.Email, "[a-zA-Z0-9]+@provide\\.com"))
                             {
                                 userToBeAssigned = await userManager.FindByEmailAsync(applicationUser.Email);
                                 await userManager.AddToRoleAsync(userToBeAssigned, "ProvideUser");
                             }
                             else if (Regex.IsMatch(applicationUser.Email, "[a-zA-Z0-9]+@search\\.com"))
                             {
                                 userToBeAssigned = await userManager.FindByEmailAsync(applicationUser.Email);
                                 await userManager.AddToRoleAsync(userToBeAssigned, "SearchUser");
                             }

                         }
                     }

                 })
                 .GetAwaiter()
                 .GetResult();


        }

    }
}

