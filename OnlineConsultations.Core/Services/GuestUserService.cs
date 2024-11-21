using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.GuestUser;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class GuestUserService : IGuestUserService
    {
        private readonly IRepository data;

        public GuestUserService(IRepository data)
        {
            this.data = data;
        }

        public async Task Add(AddGuestUserModelView addGuestUserModel)
        {
            var guestUserToBeAdded = new GuestUser()
            {
                ApplicationUserId = addGuestUserModel.ApplicationUserId
            };

            await this.data.AddAsync(guestUserToBeAdded);
            await this.data.SaveChangesAsync();
        }

        public async Task Delete(int guestUserId)
        {
            await this.data.DeleteAsync<GuestUser>(guestUserId);
            await this.data.SaveChangesAsync();
        }

        public async Task<DeleteGuestUserModelView> DeleteGuestUserForm(int guestUserId)
        {
            var guestUserToBeDeleted = await
                GetGuestUserById(guestUserId);

            var deleteGuestUserModel = new DeleteGuestUserModelView()
            {
                ApplicationUserId = guestUserToBeDeleted.ApplicationUserId
            };

            return deleteGuestUserModel;
        }

        public async Task Edit(int guestUserId, EditGuestUserModelView editGuestUserModel)
        {
            var guestUserToBeEdited = await
                GetGuestUserById(guestUserId);

            guestUserToBeEdited.ApplicationUserId = editGuestUserModel.ApplicationUserId;

            this.data.Update<GuestUser>(guestUserToBeEdited);
            await this.data.SaveChangesAsync();
        }

        public async Task<EditGuestUserModelView> EditCreateForm(int guestUserId)
        {
            var guestUserToBeEdited = await
                GetGuestUserById(guestUserId);

            var editGuestUserModel = new EditGuestUserModelView()
            {
                ApplicationUserId = guestUserToBeEdited.ApplicationUserId
            };

            return editGuestUserModel;
        }

        public async Task<IEnumerable<AllGuestUsersModelView>> GetAllGuestUsers()
        {
            var guestUsers = await data
               .AllReadonly<GuestUser>()
               .ToListAsync();

            return guestUsers
                .Select(gu => new AllGuestUsersModelView()
                {
                    ApplicationUserId = gu.ApplicationUserId 
                })
                .ToList();
        }

        public async Task<GuestUser> GetGuestUserById(int guestUserId)
        {
            var guestUser = await
              this.data
              .AllReadonly<GuestUser>()
              .Where(gu => gu.GuestUserId == guestUserId)
              .FirstOrDefaultAsync();

            if (guestUser == null)
            {
                throw new ArgumentNullException(null, nameof(guestUser));
            }

            return guestUser;
        }

        public async Task<DetailsGuestUserModelView> GetGuestUserDetailsById(int guestUserId)
        {
            var guestUser = await
               this.data
               .AllReadonly<GuestUser>()
               .Include(gu => gu.ApplicationUser)
               .Where(gu => gu.GuestUserId == guestUserId)
               .Select(gu => new DetailsGuestUserModelView()
               {
                   ApplicationUserId = gu.ApplicationUserId
               }).FirstOrDefaultAsync();

            if (guestUser == null)
            {
                throw new ArgumentNullException(null, nameof(guestUser));
            }

            return guestUser;
        }

        public async Task<IEnumerable<GuestUser>> GetGuestUsersForSelect()
        {
            return await
               this.data
               .AllReadonly<GuestUser>()
               .ToListAsync();
        }
    }
}
