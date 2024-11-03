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
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(CreatePosts());
        }

        private static List<Post> CreatePosts()
        {
            var posts = new List<Post>()
            {
                new Post()
                {
                    PostId = 1, 
                    PostTitle = "First post", 
                    PostDescription = "First Description", 
                    PostPayPerHour = 22,
                    ProvideUserId = 1
                },
                new Post()
                {
                    PostId = 2,
                    PostTitle = "Second post",
                    PostDescription = "Second Description",
                    PostPayPerHour = 24,
                    ProvideUserId = 2
                },
                new Post()
                {
                    PostId = 3,
                    PostTitle = "Third post",
                    PostDescription = "Third Description",
                    PostPayPerHour = 22,
                    ProvideUserId = 3
                },

            };

            return posts;
        }
    }
}
