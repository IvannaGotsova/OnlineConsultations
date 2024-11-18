using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.GuestUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface IGuestUserService
    {
        Task<IEnumerable<AllGuestUsersModelView>> GetAllGuestUsers();

        Task Add(AddGuestUserModelView addGuestUserModel);

        Task<IEnumerable<GuestUser>> GetGuestUsersForSelect();

        Task<DetailsGuestUserModelView> GetGuestUserDetailsById(int guestUserId);

        Task<EditGuestUserModelView> EditCreateForm(int guestUserId);

        Task Edit(int guestUserId, EditGuestUserModelView editGuestUserModel);

        Task<GuestUser> GetGuestUserById(int guestUserId);

        Task<DeleteGuestUserModelView> DeleteGuestUserForm(int guestUserId);

        Task Delete(int guestUserId);
    }
}
