using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineConsultations.Common;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Core.Services;
using OnlineConsultations.Data;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<OnlineConsultationsDbContext>
    (options => {
        options.UseSqlServer(connectionString, b => b.MigrationsAssembly("OnlineConsultations.Data"));
    });

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>
    (
    options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireDigit = true;
        options.User.RequireUniqueEmail = true;
        options.Password.RequireLowercase = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredUniqueChars = '1';
        options.Password.RequiredUniqueChars = '2';
        options.Password.RequiredUniqueChars = '3';

    })
    .AddRoles<ApplicationRole>()
    .AddEntityFrameworkStores<OnlineConsultationsDbContext>();


builder.Services.AddControllersWithViews(
    options => {
        options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
    });

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/ApplicationUsers/Login";
});

builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IAnswerService, AnswerService>();
builder.Services.AddScoped<IApplicationUserService, ApplicationUserService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IGuestUserService, GuestUserService>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IProvideUserService, ProvideUserService>();
builder.Services.AddScoped<IQuestionService, QuestionService>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<ISearchUserService, SearchUserService>();

builder.Services.AddMemoryCache();

var app = builder.Build();

app.SeedUsersRoles();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseExceptionHandler("/Home/Error");
}
else
{
    app.UseStatusCodePages();
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}"
    );

    app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

});

app.MapRazorPages();

app.Run();
     