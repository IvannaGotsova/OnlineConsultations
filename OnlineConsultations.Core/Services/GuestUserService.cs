using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.GuestUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class GuestUserService : IGuestUserService
    {
        public Task Add(AddGuestUserModelView addGuestUserModel)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int guestUserId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteGuestUserModelView> DeleteGuestUserForm(int guestUserId)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int guestUserId, EditGuestUserModelView editGuestUserModel)
        {
            throw new NotImplementedException();
        }

        public Task<EditGuestUserModelView> EditCreateForm(int guestUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllGuestUsersModelView>> GetAllGuestUsers()
        {
            throw new NotImplementedException();
        }

        public Task<GuestUser> GetGuestUserById(int guestUserId)
        {
            throw new NotImplementedException();
        }

        public Task<DetailsGuestUserModelView> GetGuestUserDetailsById(int guestUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GuestUser>> GetGuestUsersForSelect()
        {
            throw new NotImplementedException();
        }
    }
}
