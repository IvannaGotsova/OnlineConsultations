using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.Answer;
using OnlineConsultations.Data.Models.SearchUser;
using OnlineConsultations.Data.Models.SearchUser;
using OnlineConsultations.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class SearchUserService : ISearchUserService
    {
        private readonly IRepository data;

        public SearchUserService(IRepository data)
        {
            this.data = data;
        }

        public async Task Add(AddSearchUserModelView addSearchUserModel)
        {
            var searchUserToBeAdded = new SearchUser()
            {
                ApplicationUserId = addSearchUserModel.ApplicationUserId
            };

            await this.data.AddAsync(searchUserToBeAdded);
            await this.data.SaveChangesAsync();
        }

        public async Task Delete(int searchUserId)
        {
            await this.data.DeleteAsync<SearchUser>(searchUserId);
            await this.data.SaveChangesAsync();
        }

        public async Task<DeleteSearchUserModelView> DeleteSearchUserForm(int searchUserId)
        {
            var searchUserToBeDeleted = await
                GetSearchUserById(searchUserId);

            var deleteSearchUserModel = new DeleteSearchUserModelView()
            {
                ApplicationUserId = searchUserToBeDeleted.ApplicationUserId
            };

            return deleteSearchUserModel;
        }

        public async Task Edit(int searchUserId, EditSearchUserModelView editSearchUserModel)
        {
            var searchUserToBeEdited = await
                GetSearchUserById(searchUserId);

            searchUserToBeEdited.ApplicationUserId = editSearchUserModel.ApplicationUserId;

            this.data.Update<SearchUser>(searchUserToBeEdited);
            await this.data.SaveChangesAsync();
        }

        public async Task<EditSearchUserModelView> EditCreateForm(int searchUserId)
        {
            var searchUserToBeEdited = await
                GetSearchUserById(searchUserId);

            var editSearchUserModel = new EditSearchUserModelView()
            {
                ApplicationUserId = searchUserToBeEdited.ApplicationUserId
            };

            return editSearchUserModel;
        }

        public async Task<IEnumerable<AllSearchUsersModelView>> GetAllSearchUsers()
        {
            var searchUsers = await data
               .AllReadonly<SearchUser>()
               .ToListAsync();

            return searchUsers
                .Select(su => new AllSearchUsersModelView()
                {
                    ApplicationUserId = su.ApplicationUserId
                })
                .ToList();
        }

        public async Task<SearchUser> GetSearchUserById(int searchUserId)
        {
            var searchUser = await
              this.data
              .AllReadonly<SearchUser>()
              .Where(su => su.SearchUserId == searchUserId)
              .FirstOrDefaultAsync();

            if (searchUser == null)
            {
                throw new ArgumentNullException(null, nameof(searchUser));
            }

            return searchUser;
        }

        public async Task<DetailsSearchUserModelView> GetSearchUserDetailsById(int searchUserId)
        {
            var searchUser = await
               this.data
               .AllReadonly<SearchUser>()
               .Include(su => su.ApplicationUser)
               .Where(su => su.SearchUserId == searchUserId)
               .Select(su => new DetailsSearchUserModelView()
               {
                   ApplicationUserId = su.ApplicationUserId
               }).FirstOrDefaultAsync();

            if (searchUser == null)
            {
                throw new ArgumentNullException(null, nameof(searchUser));
            }

            return searchUser;
        }

        public async Task<IEnumerable<SearchUser>> GetSearchUsersForSelect()
        {
            return await
               this.data
               .AllReadonly<SearchUser>()
               .ToListAsync();
        }
    }
}
