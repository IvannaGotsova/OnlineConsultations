using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Message;
using OnlineConsultations.Data.Models.Message;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly IRepository data;

        public MessageService(IRepository data)
        {
            this.data = data;
        }

        public async Task Add(AddMessageModelView addMessageModel)
        {
            var messageToBeAdded = new Message()
            {
                MessageDescription = addMessageModel.MessageDescription,
                SearchUserId = addMessageModel.SearchUserId,
                ProvideUserId = addMessageModel.ProvideUserId
            };

            await this.data.AddAsync(messageToBeAdded);
            await this.data.SaveChangesAsync();
        }

        public async Task Delete(int messageId)
        {
            await this.data.DeleteAsync<Message>(messageId);
            await this.data.SaveChangesAsync();
        }

        public async Task<DeleteMessageModelView> DeleteMessageForm(int messageId)
        {
            var messageToBeDeleted = await
                GetMessageById(messageId);

            var deleteMessageModel = new DeleteMessageModelView()
            {
                MessageId = messageToBeDeleted.MessageId,
                MessageDescription = messageToBeDeleted.MessageDescription,
                SearchUserId = messageToBeDeleted.SearchUserId,
                ProvideUserId = messageToBeDeleted.ProvideUserId
            };

            return deleteMessageModel;
        }

        public async Task Edit(int messageId, EditMessageModelView editMessageModel)
        {
            var messageToBeEdited = await
                GetMessageById(messageId);

            messageToBeEdited.MessageDescription = editMessageModel.MessageDescription;
            messageToBeEdited.SearchUserId = editMessageModel.SearchUserId;
            messageToBeEdited.ProvideUserId = editMessageModel.ProvideUserId;

            this.data.Update<Message>(messageToBeEdited);
            await this.data.SaveChangesAsync();
        }

        public async Task<EditMessageModelView> EditCreateForm(int messageId)
        {
            var messageToBeEdited = await
                GetMessageById(messageId);

            var editMessageModel = new EditMessageModelView()
            {
                MessageDescription = messageToBeEdited.MessageDescription,
                SearchUserId = messageToBeEdited.SearchUserId,
                ProvideUserId = messageToBeEdited.ProvideUserId,
            };

            return editMessageModel;
        }

        public async Task<IEnumerable<AllMessagesModelView>> GetAllMessages()
        {
            var messages = await data
               .AllReadonly<Message>()
               .ToListAsync();

            return messages
                .Select(m => new AllMessagesModelView()
                {
                    MessageId = m.MessageId,
                    MessageDescription = m.MessageDescription,
                    SearchUserId = m.SearchUserId,
                    ProvideUserId = m.ProvideUserId,
                })
                .ToList();
        }

        public async Task<Message> GetMessageById(int messageId)
        {
            var message = await
              this.data
              .AllReadonly<Message>()
              .Where(m => m.MessageId == messageId)
              .FirstOrDefaultAsync();

            if (message == null)
            {
                throw new ArgumentNullException(null, nameof(message));
            }

            return message;
        }

        public async Task<DetailsMessageModelView> GetMessageDetailsById(int messageId)
        {
            var message = await
               this.data
               .AllReadonly<Message>()
               .Include(m => m.SearchUser)
               .Include(m => m.ProvideUser)
               .Where(m => m.MessageId == messageId)
               .Select(m => new DetailsMessageModelView()
               {
                   MessageId = m.MessageId,
                   MessageDescription = m.MessageDescription,
                   SearchUserId = m.SearchUserId,
                   ProvideUserId = m.ProvideUserId,
               }).FirstOrDefaultAsync();

            if (message == null)
            {
                throw new ArgumentNullException(null, nameof(message));
            }

            return message;
        }

        public async Task<IEnumerable<Message>> GetMessagesForSelect()
        {
            return await
               this.data
               .AllReadonly<Message>()
               .ToListAsync();
        }
    }
}
