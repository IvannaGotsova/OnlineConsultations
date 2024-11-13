using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.ApplicationUserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        public Task Delete(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserModelView> DeleteCreateForm(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetApplicaionUserById(string userId)
        {
            throw new NotImplementedException();
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
