using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.ProvideUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class ProvideUserService : IProvideUserService
    {
        public Task Add(AddProvideUserModelView addProvideUserModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int provideUserId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteProvideUserModelView> DeleteProvideUserForm(int provideUserId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int provideUserId, EditProvideUserModelView editProvideUserModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditProvideUserModelView> EditCreateForm(int provideUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllProvideUsersModelView>> GetAllProvideUsers()
        {
            throw new NotImplementedException();
        }

        public Task<ProvideUser> GetProvideUserById(int provideUserId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsProvideUserModelView> GetProvideUserDetailsById(int provideUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProvideUser>> GetProvideUsersForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
