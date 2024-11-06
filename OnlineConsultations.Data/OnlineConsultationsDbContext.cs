using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Seeds;

namespace OnlineConsultations.Data
{
    public class OnlineConsultationsDbContext : IdentityDbContext
    {
        private readonly bool seedDb;
        public OnlineConsultationsDbContext(DbContextOptions<OnlineConsultationsDbContext> options, bool seed = true)
            : base(options)
        {
            if (this.Database.IsRelational())
            {
                this.Database.Migrate();
            }
            else
            {
                this.Database.EnsureCreated();
                this.seedDb = seed;
            }
            this.seedDb = seed;
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<ApplicationUser>()
                .Property(u => u.UserName)
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Entity<ApplicationUser>()
                .Property(u => u.Email)
                .HasMaxLength(60)
                .IsRequired();

            builder
               .Entity<ApplicationUser>()
               .Property(u => u.FirstName)
               .HasMaxLength(60)
               .IsRequired();

            builder
               .Entity<ApplicationUser>()
               .Property(u => u.LastName)
               .HasMaxLength(60)
               .IsRequired();

            base.OnModelCreating(builder);

            if (this.seedDb)
            {
                builder.ApplyConfiguration(new AnswerConfiguration());
                builder.ApplyConfiguration(new ApplicationUserConfiguration());
                builder.ApplyConfiguration(new CommentConfiguration());
                builder.ApplyConfiguration(new GuestUserConfiguration());
                builder.ApplyConfiguration(new MessageConfiguration());
                builder.ApplyConfiguration(new PostConfiguration());
                builder.ApplyConfiguration(new ProvideUserConfiguration());
                builder.ApplyConfiguration(new QuestionConfiguration());
                builder.ApplyConfiguration(new RatingConfiguration());
                builder.ApplyConfiguration(new ReviewConfiguration());
                builder.ApplyConfiguration(new SearchUserConfiguration());
            }

            base.OnModelCreating(builder);
        }
    }   
}

