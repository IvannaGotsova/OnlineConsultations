using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Answer;
using OnlineConsultations.Data.Models.ProvideUser;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class ProvideUserService : IProvideUserService
    {
        private readonly IRepository data;

        public ProvideUserService(IRepository data)
        {
            this.data = data;
        }

        public async Task Add(AddProvideUserModelView addProvideUserModel)
        {
            var guestUserToBeAdded = new ProvideUser()
            {
                ApplicationUserId = addProvideUserModel.ApplicationUserId
            };

            await this.data.AddAsync(guestUserToBeAdded);
            await this.data.SaveChangesAsync();
        }

        public async Task Delete(int guestUserId)
        {
            await this.data.DeleteAsync<ProvideUser>(guestUserId);
            await this.data.SaveChangesAsync();
        }

        public async Task<DeleteProvideUserModelView> DeleteProvideUserForm(int guestUserId)
        {
            var guestUserToBeDeleted = await
                GetProvideUserById(guestUserId);

            var deleteProvideUserModel = new DeleteProvideUserModelView()
            {
                ApplicationUserId = guestUserToBeDeleted.ApplicationUserId
            };

            return deleteProvideUserModel;
        }

        public async Task Edit(int guestUserId, EditProvideUserModelView editProvideUserModel)
        {
            var guestUserToBeEdited = await
                GetProvideUserById(guestUserId);

            guestUserToBeEdited.ApplicationUserId = editProvideUserModel.ApplicationUserId;

            this.data.Update<ProvideUser>(guestUserToBeEdited);
            await this.data.SaveChangesAsync();
        }

        public async Task<EditProvideUserModelView> EditCreateForm(int guestUserId)
        {
            var guestUserToBeEdited = await
                GetProvideUserById(guestUserId);

            var editProvideUserModel = new EditProvideUserModelView()
            {
                ApplicationUserId = guestUserToBeEdited.ApplicationUserId
            };

            return editProvideUserModel;
        }

        public async Task<IEnumerable<AllProvideUsersModelView>> GetAllProvideUsers()
        {
            var guestUsers = await data
               .AllReadonly<ProvideUser>()
               .ToListAsync();

            return guestUsers
                .Select(pu=> new AllProvideUsersModelView()
                {
                    ApplicationUserId = pu.ApplicationUserId
                })
                .ToList();
        }

        public async Task<ProvideUser> GetProvideUserById(int guestUserId)
        {
            var guestUser = await
              this.data
              .AllReadonly<ProvideUser>()
              .Where(pu=> pu.ProvideUserId == guestUserId)
              .FirstOrDefaultAsync();

            if (guestUser == null)
            {
                throw new ArgumentNullException(null, nameof(guestUser));
            }

            return guestUser;
        }

        public async Task<DetailsProvideUserModelView> GetProvideUserDetailsById(int guestUserId)
        {
            var guestUser = await
               this.data
               .AllReadonly<ProvideUser>()
               .Include(pu=> pu.ApplicationUser)
               .Where(pu=> pu.ProvideUserId == guestUserId)
               .Select(pu=> new DetailsProvideUserModelView()
               {
                   ApplicationUserId = pu.ApplicationUserId
               }).FirstOrDefaultAsync();

            if (guestUser == null)
            {
                throw new ArgumentNullException(null, nameof(guestUser));
            }

            return guestUser;
        }

        public async Task<IEnumerable<ProvideUser>> GetProvideUsersForSelect()
        {
            return await
               this.data
               .AllReadonly<ProvideUser>()
               .ToListAsync();
        }
    }
}
