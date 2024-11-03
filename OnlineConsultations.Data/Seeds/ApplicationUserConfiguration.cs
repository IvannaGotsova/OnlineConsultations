using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Seeds
{
    internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(CreateApplicationUsers());
        }

        private static List<ApplicationUser> CreateApplicationUsers()
        {
            var applicationUsers = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            var applicationUser = new ApplicationUser()
            {
                Id = "admin@admin.com",
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                FirstName = "AdminFirstName",
                LastName = "AdminLastName"
            };

            applicationUser.PasswordHash =
                 hasher.HashPassword(applicationUser, "Admin123");

            applicationUsers.Add(applicationUser);

            var guestUser1 = new ApplicationUser()
            {
                Id = "guest1@guest.com",
                UserName = "guest1@guest.com",
                Email = "guest1@guest.com",
                FirstName = "GuestOneFirstName",
                LastName = "GuestOneLastName"
            };

            guestUser1.PasswordHash =
                 hasher.HashPassword(guestUser1, "Guest1123");

            applicationUsers.Add(guestUser1);

            var guestUser2 = new ApplicationUser()
            {
                Id = "guest2@guest.com",
                UserName = "guest2@guest.com",
                Email = "guest2@guest.com",
                FirstName = "GuestTwoFirstName",
                LastName = "GuestTwoLastName"
            };

            guestUser2.PasswordHash =
                 hasher.HashPassword(guestUser2, "Guest2123");

            applicationUsers.Add(guestUser2);

            var guestUser3 = new ApplicationUser()
            {
                Id = "guest3@guest.com",
                UserName = "guest3@guest.com",
                Email = "guest3@guest.com",
                FirstName = "GuestThreeFirstName",
                LastName = "GuestThreeLastName"
            };

            guestUser3.PasswordHash =
                 hasher.HashPassword(guestUser3, "Guest3123");

            applicationUsers.Add(guestUser3);

            var searchUser1 = new ApplicationUser()
            {
                Id = "search1@search.com",
                UserName = "search1@search.com",
                Email = "search1@search.com",
                FirstName = "SearchOneFirstName",
                LastName = "SearchOneLastName"
            };

            searchUser1.PasswordHash =
                 hasher.HashPassword(searchUser1, "Search1123");

            applicationUsers.Add(searchUser1);

            var searchUser2 = new ApplicationUser()
            {
                Id = "search2@search.com",
                UserName = "search2@search.com",
                Email = "search2@search.com",
                FirstName = "SearchTwoFirstName",
                LastName = "SearchTwoLastName"
            };

            searchUser2.PasswordHash =
                 hasher.HashPassword(searchUser2, "Search2123");

            applicationUsers.Add(searchUser2);

            var searchUser3 = new ApplicationUser()
            {
                Id = "search3@search.com",
                UserName = "search3@search.com",
                Email = "search3@search.com",
                FirstName = "SearchThreeFirstName",
                LastName = "SearchThreeLastName"
            };

            searchUser3.PasswordHash =
                 hasher.HashPassword(searchUser3, "Search3123");

            applicationUsers.Add(searchUser3);

            var provideUser1 = new ApplicationUser()
            {
                Id = "provide1@provide.com",
                UserName = "provide1@provide.com",
                Email = "provide1@provide.com",
                FirstName = "ProvideOneFirstName",
                LastName = "ProvideOneLastName"
            };

            provideUser1.PasswordHash =
                 hasher.HashPassword(provideUser1, "Provide1123");

            applicationUsers.Add(provideUser1);

            var provideUser2 = new ApplicationUser()
            {
                Id = "provide2@provide.com",
                UserName = "provide2@provide.com",
                Email = "provide2@provide.com",
                FirstName = "ProvideTwoFirstName",
                LastName = "ProvideTwoLastName"
            };

            provideUser2.PasswordHash =
                 hasher.HashPassword(provideUser2, "Provide2123");

            applicationUsers.Add(provideUser2);

            var provideUser3 = new ApplicationUser()
            {
                Id = "provide3@provide.com",
                UserName = "provide3@provide.com",
                Email = "provide3@provide.com",
                FirstName = "ProvideThreeFirstName",
                LastName = "ProvideThreeLastName"
            };

            provideUser3.PasswordHash =
                 hasher.HashPassword(provideUser3, "Provide3123");

            applicationUsers.Add(provideUser3);

            return applicationUsers;
        }
    }
}
