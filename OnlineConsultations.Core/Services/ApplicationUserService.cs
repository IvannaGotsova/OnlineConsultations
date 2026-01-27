using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.ApplicationUserModels;
using OnlineConsultations.Data.Repositories;
using SmoothieShop.Data.Models.ApplicationUserModels;
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

        public async Task<IEnumerable<AllApplicationUsersModel>> GetApplicationUsers()
        {
            var allUsers = await
                this.data
                .AllReadonly<ApplicationUser>()
                .ToListAsync();

            return allUsers
                .Select(u => new AllApplicationUsersModel()
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    FirstName = u.FirstName,
                    LastName = u.LastName

                })
                .ToList();
        }

        public async Task<ApplicationUser> GetApplicaionUserById(string userId)
        {
            //check if user is null
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

        public async Task<ApplicationUserModel> DeleteCreateForm(string userId)
        {
            var userToBeDeleted = await
                GetApplicaionUserById(userId);

            var deleteApplicationUserModel = new ApplicationUserModel()
            {
                Id = userToBeDeleted!.Id,
                UserName = userToBeDeleted!.UserName,
                FirstName = userToBeDeleted!.FirstName,
                LastName = userToBeDeleted!.LastName,
            };

            return deleteApplicationUserModel;
        }

        public async Task Delete(string userId)
        {
            await this.data
                .DeleteAsync<ApplicationUser>(userId);
            await this.data
                .SaveChangesAsync();
        }

        public async Task<IEnumerable<ApplicationUser>> GetApplicationUsersForSelect()
        {
            return await
                this.data
                .AllReadonly<ApplicationUser>()
                .ToListAsync();
        }

        public async Task<DetailsApplicationUserModel> GetApplicationUserDetailsById(string applicationUserId)
        {
            var applicationUser = await
               this.data
               .AllReadonly<ApplicationUser>()
               .Where(au => au.Id == applicationUserId)
               .Select(au => new DetailsApplicationUserModel()
               {
                   Id = au.Id,
                   UserName = au.UserName,
                   FirstName = au.FirstName,
                   LastName = au.LastName
               }).FirstOrDefaultAsync();

            if (applicationUser == null)
            {
                throw new ArgumentNullException(null, nameof(applicationUser));
            }

            return applicationUser;
        }

        public int Count()
        {
            return
                this.data
                .AllReadonly<ApplicationUser>()
                .Count();
        }

    }
}
