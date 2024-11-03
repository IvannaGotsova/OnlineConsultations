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
    internal class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData(CreateRatings());
        }

        private static List<Rating> CreateRatings()
        {
            var ratings = new List<Rating>()
            {
                new Rating()
                {
                   RatingId = 1,
                   RatingValue = 10, 
                   SearchUserId = 1, 
                   ProvideUserId = 1
                },
                new Rating()
                {
                   RatingId = 2,
                   RatingValue = 9,
                   SearchUserId = 1,
                   ProvideUserId = 2
                },
                new Rating()
                {
                   RatingId = 3,
                   RatingValue = 8,
                   SearchUserId = 1,
                   ProvideUserId = 3
                },
                 new Rating()
                {
                   RatingId = 4,
                   RatingValue = 10,
                   SearchUserId = 2,
                   ProvideUserId = 1
                },
                new Rating()
                {
                   RatingId = 5,
                   RatingValue = 9,
                   SearchUserId = 2,
                   ProvideUserId = 2
                },
                new Rating()
                {
                   RatingId = 6,
                   RatingValue = 9,
                   SearchUserId = 2,
                   ProvideUserId = 3
                },
                 new Rating()
                {
                   RatingId = 7,
                   RatingValue = 8,
                   SearchUserId = 3,
                   ProvideUserId = 1
                },
                new Rating()
                {
                   RatingId = 8,
                   RatingValue = 9,
                   SearchUserId = 3,
                   ProvideUserId = 2
                },
                new Rating()
                {
                   RatingId = 9,
                   RatingValue = 10,
                   SearchUserId = 3,
                   ProvideUserId = 3
                },
            };

            return ratings;
        }
    }
}

