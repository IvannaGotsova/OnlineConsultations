using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.ApplicationUserModels;
using SmoothieShop.Data.Models.ApplicationUserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Core.Contracts
{
    public interface IApplicationUserService
    {
        Task<IEnumerable<AllApplicationUsersModel>> GetApplicationUsers();
        Task<ApplicationUser> GetApplicaionUserById(string userId);
        Task<ApplicationUserModel> DeleteCreateForm(string userId);
        Task Delete(string userId);
        Task<IEnumerable<ApplicationUser>> GetApplicationUsersForSelect();
        Task<DetailsApplicationUserModel> GetApplicationUserDetailsById(string applicationUserId);
        int Count();
    }
}
