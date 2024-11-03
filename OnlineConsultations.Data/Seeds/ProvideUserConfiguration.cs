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
    internal class ProvideUserConfiguration : IEntityTypeConfiguration<ProvideUser>
    {
        public void Configure(EntityTypeBuilder<ProvideUser> builder)
        {
            builder.HasData(CreateProvideUsers());
        }

        private static List<ProvideUser> CreateProvideUsers()
        {
            var provideUsers = new List<ProvideUser>()
            {
                new ProvideUser()
                {
                   ProvideUserId = 1,
                   ApplicationUserId = "provide1@provide.com", 
                },                               
                new ProvideUser()                
                {                                
                   ProvideUserId = 2,            
                   ApplicationUserId = "provide2@provide.com"
                },                               
                new ProvideUser()                
                {                                
                   ProvideUserId = 3,            
                   ApplicationUserId = "provide3@provide.com"
                },

            };

            return provideUsers;
        }
    }
}
