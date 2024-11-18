using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface IAnswerService
    {
        Task<IEnumerable<AllAnswersModelView>> GetAllAnswers();

        Task Add(AddAnswerModelView addAnswerModel);

        Task<IEnumerable<Answer>> GetAnswersForSelect();

        Task<DetailsAnswerModelView> GetAnswerDetailsById(int answerId);

        Task<EditAnswerModelView> EditCreateForm(int answerId);

        Task Edit(int answerId, EditAnswerModelView editAnswerModel);

        Task<Answer> GetAnswerById(int answerId);

        Task<DeleteAnswerModelView> DeleteAnswerForm(int answerId);

        Task Delete(int answerId);
    }
}
