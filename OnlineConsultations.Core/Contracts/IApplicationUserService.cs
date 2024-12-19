using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.ApplicationUserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface IApplicationUserService
    {
        Task<IEnumerable<ApplicationUserModelView>> GetApplicationUsers();

        Task<ApplicationUser> GetApplicaionUserById(string userId);
      
        Task<ApplicationUserModelView> DeleteCreateForm(string userId);
     
        Task Delete(string userId);
       
        Task<IEnumerable<ApplicationUser>> GetApplicationUsersForSelect();

        public int GetApplicationUsersCount();
    }
}
