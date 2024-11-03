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
    internal class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(CreateQuestions());
        }

        private static List<Question> CreateQuestions()
        {
            var questions = new List<Question>()
            {
                new Question()
                {
                   QuestionId = 1,
                   QuestionTitle = "First", 
                   QuestionDescription = "First Description", 
                   QuestionDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 1                 
                },
                new Question()
                {
                   QuestionId = 2,
                   QuestionTitle = "Second",
                   QuestionDescription = "Second Description",
                   QuestionDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 2
                },
                  new Question()
                {
                   QuestionId = 3, 
                   QuestionTitle = "Third",
                   QuestionDescription = "Third Description",
                   QuestionDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   SearchUserId = 3
                },
                 new Question()
                {
                   QuestionId = 4,
                   QuestionTitle = "Fourth",
                   QuestionDescription = "Fourth Description",
                   QuestionDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   GuestUserId = 1
                },
            };

            return  questions;
        }
    }
}