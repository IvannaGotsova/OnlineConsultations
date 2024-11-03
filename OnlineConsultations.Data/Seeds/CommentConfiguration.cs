using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Seeds
{
    internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(CreateComments());
        }

        private static List<Comment> CreateComments()
        {
            var comments = new List<Comment>()
            {
                new Comment()
                {
                   CommentId = 1,
                   CommentTitle = "First",
                   CommentDescription = "Comment First",
                   GuestUserId = 1,
                   AnswerId = 1
                },
                new Comment()
                {
                   CommentId = 2,
                   CommentTitle = "Second",
                   CommentDescription = "Comment Second",
                    GuestUserId = 1,
                   AnswerId = 1,
                },
                new Comment()
                {
                   CommentId = 3,
                   CommentTitle = "Third",
                   CommentDescription = "Comment Third",
                   GuestUserId = 2,
                   AnswerId = 2
                },
                new Comment()
                {
                   CommentId = 4,
                   CommentTitle = "Fourth",
                   CommentDescription = "Comment Fourth",
                   GuestUserId = 2,
                   AnswerId = 3,
                },
                new Comment()
                {
                   CommentId = 5,
                   CommentTitle = "Fifth",
                   CommentDescription = "Comment Fifth",
                   GuestUserId = 1,
                   AnswerId = 3,
                },
                new Comment()
                {
                   CommentId = 6,
                   CommentTitle = "Sixth",
                   CommentDescription = "Comment Sixth",
                   SearchUserId = 1,
                   AnswerId = 3,
                },
                new Comment()
                {
                   CommentId = 7,
                   CommentTitle = "Seventh",
                   CommentDescription = "Comment Seventh",
                    SearchUserId = 1,
                   AnswerId = 2,
                },
                new Comment()
                {
                   CommentId = 8,
                   CommentTitle = "Eight",
                   CommentDescription = "Comment Eight",
                   SearchUserId = 2,
                   AnswerId = 4,
                },
                new Comment()
                {
                   CommentId = 9,
                   CommentTitle = "Ninth",
                   CommentDescription = "Comment Ninth",
                   SearchUserId = 2,
                   AnswerId = 1,
                },
                new Comment()
                {
                   CommentId = 10,
                   CommentTitle = "Tenth",
                   CommentDescription = "Comment Tenth",
                   SearchUserId = 2,
                   AnswerId = 2,
                },
                new Comment()
                {
                   CommentId = 11,
                   CommentTitle = "Eleven",
                   CommentDescription = "Comment Eleven",
                   SearchUserId = 3,
                   AnswerId = 2,
                },
                new Comment()
                {
                   CommentId = 12,
                   CommentTitle = "Twelve",
                   CommentDescription = "Comment Twelve",
                   SearchUserId = 3,
                   AnswerId = 2,
                },
            };

            return comments;
        }
    }
}