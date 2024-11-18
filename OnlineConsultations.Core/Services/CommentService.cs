using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class CommentService : ICommentService
    {
        public Task Add(AddCommentModelView addCommentModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteCommentModelView> DeleteCommentForm(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int commentId, EditCommentModelView editCommentModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditCommentModelView> EditCreateForm(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllCommentsModelView>> GetAllComments()
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetCommentById(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsCommentModelView> GetCommentDetailsById(int commentId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comment>> GetCommentsForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
