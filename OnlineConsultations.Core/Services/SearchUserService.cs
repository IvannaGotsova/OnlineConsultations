using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.SearchUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class SearchUserService : ISearchUserService
    {
        public Task Add(AddSearchUserModelView addSearchUserModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int searchUserId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteSearchUserModelView> DeleteSearchUserForm(int searchUserId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int searchUserId, EditSearchUserModelView editSearchUserModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditSearchUserModelView> EditCreateForm(int searchUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllSearchUsersModelView>> GetAllSearchUsers()
        {
            throw new NotImplementedException();
        }

        public Task<SearchUser> GetSearchUserById(int searchUserId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsSearchUserModelView> GetSearchUserDetailsById(int searchUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SearchUser>> GetSearchUsersForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
