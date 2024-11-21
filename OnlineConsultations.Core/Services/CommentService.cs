using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Comment;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepository data;

        public CommentService(IRepository data)
        {
            this.data = data;
        }

        public async Task Add(AddCommentModelView addCommentModel)
        {
            var commentToBeAdded = new Comment()
            {
                CommentTitle = addCommentModel.CommentTitle,
                CommentDescription = addCommentModel.CommentDescription,
                GuestUserId = addCommentModel.GuestUserId,
                SearchUserId = addCommentModel.SearchUserId,
                AnswerId = addCommentModel.AnswerId
            };

            await this.data.AddAsync(commentToBeAdded);
            await this.data.SaveChangesAsync();
        }

        public async Task Delete(int commentId)
        {
            await this.data.DeleteAsync<Comment>(commentId);
            await this.data.SaveChangesAsync();
        }

        public async Task<DeleteCommentModelView> DeleteCommentForm(int commentId)
        {
            var commentToBeDeleted = await
                GetCommentById(commentId);

            var deleteCommentModel = new DeleteCommentModelView()
            {
                CommentId = commentToBeDeleted.CommentId,
                CommentTitle = commentToBeDeleted.CommentTitle,
                CommentDescription = commentToBeDeleted.CommentDescription,
                GuestUserId = commentToBeDeleted.GuestUserId,
                SearchUserId = commentToBeDeleted.SearchUserId,
                AnswerId = commentToBeDeleted.AnswerId
            };

            return deleteCommentModel;
        }

        public async Task Edit(int commentId, EditCommentModelView editCommentModel)
        {
            var commentToBeEdited = await
                GetCommentById(commentId);

            commentToBeEdited.CommentTitle = editCommentModel.CommentTitle;
            commentToBeEdited.CommentDescription = editCommentModel.CommentDescription;
            commentToBeEdited.GuestUserId = editCommentModel.GuestUserId;
            commentToBeEdited.SearchUserId = editCommentModel.SearchUserId;
            commentToBeEdited.AnswerId = editCommentModel.AnswerId;

            this.data.Update<Comment>(commentToBeEdited);
            await this.data.SaveChangesAsync();
        }

        public async Task<EditCommentModelView> EditCreateForm(int commentId)
        {
            var commentToBeEdited = await
                GetCommentById(commentId);

            var editCommentModel = new EditCommentModelView()
            {
                CommentTitle = commentToBeEdited.CommentTitle,
                CommentDescription = commentToBeEdited.CommentDescription,
                GuestUserId = commentToBeEdited.GuestUserId,
                SearchUserId = commentToBeEdited.SearchUserId,
                AnswerId = commentToBeEdited.AnswerId
            };

            return editCommentModel;
        }

        public async Task<IEnumerable<AllCommentsModelView>> GetAllComments()
        {
            var comments = await data
               .AllReadonly<Comment>()
               .ToListAsync();

            return comments
                .Select(c => new AllCommentsModelView()
                {
                    CommentTitle = c.CommentTitle,
                    CommentDescription = c.CommentDescription,
                    GuestUserId = c.GuestUserId,
                    SearchUserId = c.SearchUserId,
                    AnswerId = c.AnswerId
                })
                .ToList();
        }

        public async Task<Comment> GetCommentById(int commentId)
        {
            var comment = await
              this.data
              .AllReadonly<Comment>()
              .Where(a => a.CommentId == commentId)
              .FirstOrDefaultAsync();

            if (comment == null)
            {
                throw new ArgumentNullException(null, nameof(comment));
            }

            return comment;
        }

        public async Task<DetailsCommentModelView> GetCommentDetailsById(int commentId)
        {
            var comment = await
               this.data
               .AllReadonly<Comment>()
               .Include(c => c.Answer)
               .Include(a => a.GuestUser)
               .Include(a => a.SearchUser)
               .Where(c => c.CommentId == commentId)
               .Select(c => new DetailsCommentModelView()
               {
                   CommentTitle = c.CommentTitle,
                   CommentDescription = c.CommentDescription,
                   GuestUserId = c.GuestUserId,
                   SearchUserId = c.SearchUserId,
                   AnswerId = c.AnswerId
               }).FirstOrDefaultAsync();

            if (comment == null)
            {
                throw new ArgumentNullException(null, nameof(comment));
            }

            return comment;
        }

        public async Task<IEnumerable<Comment>> GetCommentsForSelect()
        {
            return await
               this.data
               .AllReadonly<Comment>()
               .ToListAsync();
        }
    }
}
