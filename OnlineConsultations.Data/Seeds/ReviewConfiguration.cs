using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OnlineConsultations.Data.Seeds
{
    internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(CreateReviews());
        }

        private static List<Review> CreateReviews()
        {
            var reviews = new List<Review>()
            {
                new Review()
                {
                   ReviewId = 1,
                   ReviewDescription = "First description",
                   ReviewDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 1,
                   ProvideUserId = 1
                },
                new Review()
                {
                   ReviewId = 2,
                   ReviewDescription = "Second description",
                   ReviewDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 1,
                   ProvideUserId = 2
                },
                new Review()
                {
                   ReviewId = 3,
                   ReviewDescription = "Third description",
                   ReviewDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 1,
                   ProvideUserId = 3
                },
                 new Review()
                {
                   ReviewId = 4,
                   ReviewDescription = "Fourth description",
                   ReviewDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 2,
                   ProvideUserId = 1
                },
                new Review()
                {
                   ReviewId = 5,
                   ReviewDescription = "Fifth description",
                   ReviewDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 2,
                   ProvideUserId = 2
                },
                new Review()
                {
                   ReviewId = 6,
                   ReviewDescription = "Sixth description",
                   ReviewDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 2,
                   ProvideUserId = 3
                },
                 new Review()
                {
                   ReviewId = 7,
                   ReviewDescription = "Seventh description",
                   ReviewDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 3,
                   ProvideUserId = 1
                },
                new Review()
                {
                   ReviewId = 8,
                   ReviewDescription = "Eight description",
                   ReviewDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 3,
                   ProvideUserId = 2
                },
                new Review()
                {
                   ReviewId = 9,
                   ReviewDescription = "Ninth description",
                   ReviewDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 3,
                   ProvideUserId = 3
                },
            };

            return reviews;
        }
    }
}

