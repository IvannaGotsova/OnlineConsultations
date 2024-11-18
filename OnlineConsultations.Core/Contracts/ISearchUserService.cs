using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.SearchUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface ISearchUserService
    {
        Task<IEnumerable<AllSearchUsersModelView>> GetAllSearchUsers();

        Task Add(AddSearchUserModelView addSearchUserModel);

        Task<IEnumerable<SearchUser>> GetSearchUsersForSelect();

        Task<DetailsSearchUserModelView> GetSearchUserDetailsById(int searchUserId);

        Task<EditSearchUserModelView> EditCreateForm(int searchUserId);

        Task Edit(int searchUserId, EditSearchUserModelView editSearchUserModel);

        Task<SearchUser> GetSearchUserById(int searchUserId);

        Task<DeleteSearchUserModelView> DeleteSearchUserForm(int searchUserId);

        Task Delete(int searchUserId);
    }
}
