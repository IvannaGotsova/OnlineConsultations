using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.ApplicationUserModels;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IRepository data;
        public ApplicationUserService(IRepository data)
        {
            this.data = data;
        }
        public async Task Delete(string userId)
        {
            await this.data
               .DeleteAsync<ApplicationUser>(userId);
            await this.data
                .SaveChangesAsync();
        }

        public async Task<ApplicationUserModelView> DeleteCreateForm(string userId)
        {
            var userToBeDeleted = await
                GetApplicaionUserById(userId);

            var deleteApplicationUserModel = new ApplicationUserModelView()
            {
                Id = userToBeDeleted!.Id,
                UserName = userToBeDeleted!.UserName,
                FirstName = userToBeDeleted!.FirstName,
                LastName = userToBeDeleted!.LastName,
            };

            return deleteApplicationUserModel;
        }

        public async Task<ApplicationUser> GetApplicaionUserById(string userId)
        {
            if (await this.data
               .GetByIdAsync<ApplicationUser>(userId) == null)
            {
                throw new ArgumentNullException(null, nameof(userId));
            }

            return await
               this.data
               .AllReadonly<ApplicationUser>()
               .Where(au => au.Id == userId)
               .FirstAsync();
        }

        public Task<IEnumerable<ApplicationUserModelView>> GetApplicationUsers()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUser>> GetApplicationUsersForSelect()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApplicationUserModelView>> GetApplicationVIPUsers()
        {
            throw new NotImplementedException();
        }

        public Task MakeVIP(string userId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveVIP(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
