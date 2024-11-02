using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnlineConsultations.Data
{
    public class OnlineConsultationsDbContext : IdentityDbContext
    {
        public OnlineConsultationsDbContext(DbContextOptions<OnlineConsultationsDbContext> options)
            : base(options)
        {
           
        }
    }
}
