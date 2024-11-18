using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class AnswerService : IAnswerService
    {
        public Task Add(AddCommentModelView addAnswerModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int answerId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteCommentModelView> DeleteAnswerForm(int answerId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int answerId, EditCommentModelView editAnswerModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditCommentModelView> EditCreateForm(int answerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllCommentsModelView>> GetAllAnswers()
        {
            throw new NotImplementedException();
        }

        public Task<Answer> GetAnswerById(int answerId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsCommentModelView> GetAnswerDetailsById(int answerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Answer>> GetAnswersForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
