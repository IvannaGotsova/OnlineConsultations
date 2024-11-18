using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface ICommentService
    {
        Task<IEnumerable<AllCommentsModelView>> GetAllComments();

        Task Add(AddCommentModelView addCommentModel);

        Task<IEnumerable<Comment>> GetCommentsForSelect();

        Task<DetailsCommentModelView> GetCommentDetailsById(int commentId);

        Task<EditCommentModelView> EditCreateForm(int commentId);

        Task Edit(int commentId, EditCommentModelView editCommentModel);

        Task<Comment> GetCommentById(int commentId);

        Task<DeleteCommentModelView> DeleteCommentForm(int commentId);

        Task Delete(int commentId);
    }
}
