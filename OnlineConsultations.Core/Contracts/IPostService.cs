using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface IPostService
    {
        Task<IEnumerable<AllPostsModelView>> GetAllPosts();

        Task Add(AddPostModelView addPostModel);

        Task<IEnumerable<Post>> GetPostsForSelect();

        Task<DetailsPostModelView> GetPostDetailsById(int postId);

        Task<EditPostModelView> EditCreateForm(int postId);

        Task Edit(int postId, EditPostModelView editPostModel);

        Task<Post> GetPostById(int postId);

        Task<DeletePostModelView> DeletePostForm(int postId);

        Task Delete(int postId);
    }
}
