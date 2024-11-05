using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OnlineConsultations.Data;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<OnlineConsultationsDbContext>
    (options => {
        options.UseSqlServer(connectionString, b => b.MigrationsAssembly("OnlineConsultations.Data"));
        options.UseSqlServer(connectionString);
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
// !!! to add services later

builder.Services.AddMemoryCache();

var app = builder.Build();

// app.SeedUsersRoles();

// Configure the HTTP request pipeline.
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
app.UseHsts();

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
