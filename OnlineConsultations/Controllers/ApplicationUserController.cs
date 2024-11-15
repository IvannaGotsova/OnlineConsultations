using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Entities;
using OnlineConsultations.Data.Models.ApplicationUserModels;

namespace OnlineConsultations.Controllers
{
    public class ApplicationUserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IApplicationUserService applicationUserService;

        public ApplicationUserController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IApplicationUserService applicationUserService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.applicationUserService = applicationUserService;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            RegisterModelView modelToBeRegistered = new();

            TempData["message"] = $"Hello! Welcome!";

            return View(modelToBeRegistered);
        }
        
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterModelView modelToBeRegistered)
        {
           
            if (!ModelState.IsValid)
            {
                return View(modelToBeRegistered);
            }
            
            ApplicationUser userToBeRegistered = new()
            {
                UserName = modelToBeRegistered.UserName,
                Email = modelToBeRegistered.Email,
                FirstName = modelToBeRegistered.FirstName,
                LastName = modelToBeRegistered.LastName
            };

            var resultUserToBeRegistered = await userManager
                .CreateAsync(userToBeRegistered, modelToBeRegistered.Password);
            
            if (!resultUserToBeRegistered.Succeeded)
            {
                foreach (var error in resultUserToBeRegistered.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(modelToBeRegistered);
            }



            return RedirectToAction("Login", "ApplicationUser");
        }
        
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {

            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }

            
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            LoginModelView modelToBeLogin = new();

            TempData["message"] = $"Hello! Have a great time!";

            return View(modelToBeLogin);
        }
       
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModelView modelToBeLogin)
        {   
            if (!ModelState.IsValid)
            {
                return View(modelToBeLogin);
            }

            var userToBeLogin = await userManager
                .FindByNameAsync(modelToBeLogin.UserName);
           
            if (userToBeLogin != null)
            {
                var resultUserToBeLogin = await signInManager
                    .PasswordSignInAsync(userToBeLogin, modelToBeLogin.Password, true, false);

                if (resultUserToBeLogin.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

            }

            ModelState.AddModelError("", "Invalid login attempt.");

            return View(modelToBeLogin);

        }
        
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            TempData["message"] = $"Goodbye! We are waiting for you to come back";

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AllApplicationUsers()
        {
            try
            {
                var allApplicationUsers = await
                    applicationUserService
                   .GetApplicationUsers();

                return View(allApplicationUsers);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
    }
}
