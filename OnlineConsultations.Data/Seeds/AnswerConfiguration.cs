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
    internal class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasData(CreateAnswers());
        }

        private static List<Answer> CreateAnswers()
        {
            var answers = new List<Answer>()
            {
                new Answer()
                {
                   AnswerId = 1,
                   AnswerDescription = "Answer First", 
                   AnswerDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   ProvideUserId = 1,
                   QuestionId = 1,
                },
                new Answer()
                {
                   AnswerId = 2,
                   AnswerDescription = "Answer Second",
                   AnswerDate =  DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   ProvideUserId = 1,
                   QuestionId = 2,
                },
                new Answer()
                {
                   AnswerId = 3,
                   AnswerDescription = "Answer Third",
                   AnswerDate =  DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   ProvideUserId = 1,
                   QuestionId = 3,
                },
                new Answer()
                {
                   AnswerId = 4,
                   AnswerDescription = "Answer Fourth",
                   AnswerDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   ProvideUserId = 2,
                   QuestionId = 1,
                },
                new Answer()
                {
                   AnswerId = 5,
                   AnswerDescription = "Answer Fifth",
                   AnswerDate = DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   ProvideUserId = 2,
                   QuestionId = 3,
                },
                new Answer()
                {
                   AnswerId = 6,
                   AnswerDescription = "Answer Sixth",
                   AnswerDate =  DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   ProvideUserId = 2,
                   QuestionId = 3,
                },
                new Answer()
                {
                   AnswerId = 7,
                   AnswerDescription = "Answer Seventh",
                   AnswerDate =  DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   ProvideUserId = 3,
                   QuestionId = 2,
                },
                new Answer()
                {
                   AnswerId = 8,
                   AnswerDescription = "Answer Eighth",
                   AnswerDate =  DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   ProvideUserId = 3,
                   QuestionId = 2,
                },
                 new Answer()
                {
                   AnswerId = 9,
                   AnswerDescription = "Answer Ninth",
                   AnswerDate =  DateTime.ParseExact("01/01/2024", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                   ProvideUserId = 3,
                   QuestionId = 3,
                },
            };

            return answers;
        }
    }
}