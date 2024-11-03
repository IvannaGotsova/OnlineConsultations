using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineConsultations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Seeds
{
    internal class GuestUserConfiguration : IEntityTypeConfiguration<GuestUser>
    {
        public void Configure(EntityTypeBuilder<GuestUser> builder)
        {
            builder.HasData(CreateGuestUsers());
        }

        private static List<GuestUser> CreateGuestUsers()
        {
            var guestUsers = new List<GuestUser>()
            {
                new GuestUser()
                {
                   GuestUserId = 1,
                   ApplicationUserId = "guest1@guest.com"
                },
                new GuestUser()
                {
                   GuestUserId = 2,
                   ApplicationUserId = "guest2@guest.com"
                },
                new GuestUser()
                {
                   GuestUserId = 3,
                   ApplicationUserId = "guest3@guest.com"
                },

            };

            return guestUsers;
        }
    }
}
