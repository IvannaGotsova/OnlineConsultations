using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class MessageService : IMessageService
    {
        public Task Add(AddMessageModelView addMessageModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int messageId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteMessageModelView> DeleteMessageForm(int messageId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int messageId, EditMessageModelView editMessageModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditMessageModelView> EditCreateForm(int messageId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllMessagesModelView>> GetAllMessages()
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetMessageById(int messageId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsMessageModelView> GetMessageDetailsById(int messageId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Message>> GetMessagesForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
