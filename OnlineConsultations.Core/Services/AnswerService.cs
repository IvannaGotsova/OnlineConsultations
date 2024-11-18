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
        public Task Add(AddAnswerModelView addAnswerModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int answerId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteAnswerModelView> DeleteAnswerForm(int answerId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int answerId, EditAnswerModelView editAnswerModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditAnswerModelView> EditCreateForm(int answerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllAnswersModelView>> GetAllAnswers()
        {
            throw new NotImplementedException();
        }

        public Task<Answer> GetAnswerById(int answerId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsAnswerModelView> GetAnswerDetailsById(int answerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Answer>> GetAnswersForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
