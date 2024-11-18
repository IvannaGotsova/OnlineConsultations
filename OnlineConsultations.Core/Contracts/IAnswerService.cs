using OnlineConsultations.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineConsultations.Data.Models.Answer;

namespace OnlineConsultations.Core.Contracts
{
    public interface IAnswerService
    {
        Task<IEnumerable<AllCommentsModelView>> GetAllAnswers();

        Task Add(AddCommentModelView addAnswerModel);

        Task<IEnumerable<Answer>> GetAnswersForSelect();

        Task<DetailsCommentModelView> GetAnswerDetailsById(int answerId);

        Task<EditCommentModelView> EditCreateForm(int answerId);

        Task Edit(int answerId, EditCommentModelView editAnswerModel);

        Task<Answer> GetAnswerById(int answerId);

        Task<DeleteCommentModelView> DeleteAnswerForm(int answerId);

        Task Delete(int answerId);
    }
}
