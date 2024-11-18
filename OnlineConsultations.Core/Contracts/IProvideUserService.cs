using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.ProvideUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface IProvideUserService
    {
        Task<IEnumerable<AllProvideUsersModelView>> GetAllProvideUsers();

        Task Add(AddProvideUserModelView addProvideUserModel);

        Task<IEnumerable<ProvideUser>> GetProvideUsersForSelect();

        Task<DetailsProvideUserModelView> GetProvideUserDetailsById(int provideUserId);

        Task<EditProvideUserModelView> EditCreateForm(int provideUserId);

        Task Edit(int provideUserId, EditProvideUserModelView editProvideUserModel);

        Task<ProvideUser> GetProvideUserById(int provideUserId);

        Task<DeleteProvideUserModelView> DeleteProvideUserForm(int provideUserId);

        Task Delete(int provideUserId);
    }
}
