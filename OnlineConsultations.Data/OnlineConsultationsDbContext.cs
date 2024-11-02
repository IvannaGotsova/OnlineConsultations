using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Data.Entities;

namespace OnlineConsultations.Data
{
    public class OnlineConsultationsDbContext : IdentityDbContext
    {
        public OnlineConsultationsDbContext(DbContextOptions<OnlineConsultationsDbContext> options)
            : base(options)
        {
            if (this.Database.IsRelational())
            {
                this.Database.Migrate();
            }
            else
            {
                this.Database.EnsureCreated();
                //this.seedDb = seed;
            }

        }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; } = null!;
        public DbSet<Answer> Answers { get; set; } = null!;
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<GuestUser> GuestUsers { get; set; } = null!;
        public DbSet<Message> Messages { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<ProvideUser> ProvideUsers { get; set; } = null!;
        public DbSet<Question> Questions { get; set; } = null!;
        public DbSet<Rating> Ratings { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<SearchUser> SearchUsers { get; set; } = null!;
    }
}
