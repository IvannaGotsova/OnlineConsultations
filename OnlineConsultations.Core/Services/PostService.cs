using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Post;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository data;

        public PostService(IRepository data)
        {
            this.data = data;
        }

        public async Task Add(AddPostModelView addPostModel)
        {
            var postToBeAdded = new Post()
            {
                PostDescription = addPostModel.PostDescription,
                PostTitle = addPostModel.PostTitle,
                PostPayPerHour = addPostModel.PostPayPerHour,
                ProvideUserId = addPostModel.ProvideUserId
            };

            await this.data.AddAsync(postToBeAdded);
            await this.data.SaveChangesAsync();
        }

        public async Task Delete(int postId)
        {
            await this.data.DeleteAsync<Post>(postId);
            await this.data.SaveChangesAsync();
        }

        public async Task<DeletePostModelView> DeletePostForm(int postId)
        {
            var postToBeDeleted = await
                GetPostById(postId);

            var deletePostModel = new DeletePostModelView()
            {
                PostId = postToBeDeleted.PostId,
                PostDescription = postToBeDeleted.PostDescription,
                PostTitle = postToBeDeleted.PostTitle,
                PostPayPerHour = postToBeDeleted.PostPayPerHour,
                ProvideUserId = postToBeDeleted.ProvideUserId
            };

            return deletePostModel;
        }

        public async Task Edit(int postId, EditPostModelView editPostModel)
        {
            var postToBeEdited = await
                GetPostById(postId);

            postToBeEdited.PostDescription = editPostModel.PostDescription;
            postToBeEdited.PostTitle = editPostModel.PostTitle;
            postToBeEdited.PostPayPerHour = editPostModel.PostPayPerHour;
            postToBeEdited.ProvideUserId = editPostModel.ProvideUserId;

            this.data.Update<Post>(postToBeEdited);
            await this.data.SaveChangesAsync();
        }

        public async Task<EditPostModelView> EditCreateForm(int postId)
        {
            var postToBeEdited = await
                GetPostById(postId);

            var editPostModel = new EditPostModelView()
            {
                PostDescription = postToBeEdited.PostDescription,
                PostTitle = postToBeEdited.PostTitle,
                PostPayPerHour = postToBeEdited.PostPayPerHour,
                ProvideUserId = postToBeEdited.ProvideUserId,
            };

            return editPostModel;
        }

        public async Task<IEnumerable<AllPostsModelView>> GetAllPosts()
        {
            var posts = await data
               .AllReadonly<Post>()
               .ToListAsync();

            return posts
                .Select(p => new AllPostsModelView()
                {
                    PostId = p.PostId,
                    PostDescription = p.PostDescription,
                    PostTitle = p.PostTitle,
                    PostPayPerHour = p.PostPayPerHour,
                    ProvideUserId = p.ProvideUserId,
                })
                .ToList();
        }

        public async Task<Post> GetPostById(int postId)
        {
            var post = await
              this.data
              .AllReadonly<Post>()
              .Where(a => a.PostId == postId)
              .FirstOrDefaultAsync();

            if (post == null)
            {
                throw new ArgumentNullException(null, nameof(post));
            }

            return post;
        }

        public async Task<DetailsPostModelView> GetPostDetailsById(int postId)
        {
            var post = await
               this.data
               .AllReadonly<Post>()
               .Include(p => p.ProvideUser)
               .Where(p => p.PostId == postId)
               .Select(p => new DetailsPostModelView()
               {
                   PostId = p.PostId,
                   PostDescription = p.PostDescription,
                   PostTitle = p.PostTitle,
                   PostPayPerHour = p.PostPayPerHour,
                   ProvideUserId = p.ProvideUserId,
               }).FirstOrDefaultAsync();

            if (post == null)
            {
                throw new ArgumentNullException(null, nameof(post));
            }

            return post;
        }

        public async Task<IEnumerable<Post>> GetPostsForSelect()
        {
            return await
               this.data
               .AllReadonly<Post>()
               .ToListAsync();
        }
    }
}
