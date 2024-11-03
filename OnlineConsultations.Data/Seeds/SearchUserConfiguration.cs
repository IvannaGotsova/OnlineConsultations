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
    internal class SearchUserConfiguration : IEntityTypeConfiguration<SearchUser>
    {
        public void Configure(EntityTypeBuilder<SearchUser> builder)
        {
            builder.HasData(CreateSearchUsers());
        }

        private static List<SearchUser> CreateSearchUsers()
        {
            var searchUsers = new List<SearchUser>()
            {
                new SearchUser()
                {
                   SearchUserId = 1,
                   ApplicationUserId = "search1@search.com"
                },
                new SearchUser()
                {
                   SearchUserId = 2,
                   ApplicationUserId = "search2@search.com"
                },
                new SearchUser()
                {
                   SearchUserId = 3,
                   ApplicationUserId = "search3@search.com"
                },

            };

            return searchUsers;
        }
    }
}