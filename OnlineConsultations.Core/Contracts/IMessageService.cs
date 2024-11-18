using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface IMessageService
    {
        Task<IEnumerable<AllMessagesModelView>> GetAllMessages();

        Task Add(AddMessageModelView addMessageModel);

        Task<IEnumerable<Message>> GetMessagesForSelect();

        Task<DetailsMessageModelView> GetMessageDetailsById(int messageId);

        Task<EditMessageModelView> EditCreateForm(int messageId);

        Task Edit(int messageId, EditMessageModelView editMessageModel);

        Task<Message> GetMessageById(int messageId);

        Task<DeleteMessageModelView> DeleteMessageForm(int messageId);

        Task Delete(int messageId);
    }
}
