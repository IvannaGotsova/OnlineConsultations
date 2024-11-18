using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class QuestionService : IQuestionService
    {
        public Task Add(AddQuestionModelView addQuestionModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int questionId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteQuestionModelView> DeleteQuestionForm(int questionId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int questionId, EditQuestionModelView editQuestionModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditQuestionModelView> EditCreateForm(int questionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllQuestionsModelView>> GetAllQuestions()
        {
            throw new NotImplementedException();
        }

        public Task<Question> GetQuestionById(int questionId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsQuestionModelView> GetQuestionDetailsById(int questionId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> GetQuestionsForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
