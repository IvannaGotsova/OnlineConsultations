using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface IQuestionService
    {
        Task<IEnumerable<AllQuestionsModelView>> GetAllQuestions();

        Task Add(AddQuestionModelView addQuestionModel);

        Task<IEnumerable<Question>> GetQuestionsForSelect();

        Task<DetailsQuestionModelView> GetQuestionDetailsById(int questionId);

        Task<EditQuestionModelView> EditCreateForm(int questionId);

        Task Edit(int questionId, EditQuestionModelView editQuestionModel);

        Task<Question> GetQuestionById(int questionId);

        Task<DeleteQuestionModelView> DeleteQuestionForm(int questionId);

        Task Delete(int questionId);
    }
}
