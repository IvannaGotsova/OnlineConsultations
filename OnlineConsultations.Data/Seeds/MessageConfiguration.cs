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
    internal class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasData(CreateMessages());
        }

        private static List<Message> CreateMessages()
        {
            var messages = new List<Message>()
            {
                new Message()
                {
                   MessageId = 1,
                   MessageDescription = "First message",
                   ProvideUserId = 1, 
                   SearchUserId = 1, 
                },
                new Message()
                {
                   MessageId = 2,
                   MessageDescription = "Second message",
                   ProvideUserId = 1,
                   SearchUserId = 2,
                },
                new Message()
                {
                   MessageId = 3,
                   MessageDescription = "Third message",
                   ProvideUserId = 2,
                   SearchUserId = 3,
                },
                new Message()
                {
                   MessageId = 4,
                   MessageDescription = "Fourth message",
                   ProvideUserId = 1,
                   SearchUserId = 1,
                },
                new Message()
                {
                   MessageId = 5,
                   MessageDescription = "Fifth message",
                   ProvideUserId = 3,
                   SearchUserId = 2,
                },
                new Message()
                {
                   MessageId = 6,
                   MessageDescription = "Sixth message",
                   ProvideUserId = 1,
                   SearchUserId = 3,
                },
                new Message()
                {
                   MessageId = 7,
                   MessageDescription = "Seventh message",
                   ProvideUserId = 3,
                   SearchUserId = 1,
                },
                new Message()
                {
                   MessageId = 8,
                   MessageDescription = "Eight message",
                   ProvideUserId = 1,
                   SearchUserId = 2,
                },
                new Message()
                {
                   MessageId = 9,
                   MessageDescription = "Ninth message",
                   ProvideUserId = 2,
                   SearchUserId = 1,
                },
                new Message()
                {
                   MessageId = 10,
                   MessageDescription = "Tenth message",
                   ProvideUserId = 2,
                   SearchUserId = 3,
                },
            };

            return messages;
        }
    }
}
