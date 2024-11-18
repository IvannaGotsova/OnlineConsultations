using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class PostService : IPostService
    {
        public Task Add(AddPostModelView addPostModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<DeletePostModelView> DeletePostForm(int postId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int postId, EditPostModelView editPostModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditPostModelView> EditCreateForm(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllPostsModelView>> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostById(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsPostModelView> GetPostDetailsById(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Post>> GetPostsForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
