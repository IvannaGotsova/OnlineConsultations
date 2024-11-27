using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Models.ProvideUser;
using static OnlineConsultations.ErrorConstants.ErrorConstants.GlobalErrorConstants;

namespace OnlineConsultations.Controllers
{
    public class ProvideUserController : Controller
    {
        private readonly IProvideUserService provideUserService;

        public ProvideUserController(IProvideUserService provideUserService)
        {
            this.provideUserService = provideUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllProvideUsers()
        {
            try
            {
                var provideUsers = await
                    provideUserService
                   .GetAllProvideUsers();

                return View(provideUsers);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddProvideUser()
        {
            var modelProvideUser = await Task.Run(() => new AddProvideUserModelView());

            return View(modelProvideUser);
        }

        [HttpPost]
        public async Task<IActionResult> AddProvideUser(AddProvideUserModelView addProvideUserModel)
        {

            if (!ModelState.IsValid)
            {
                return View(addProvideUserModel);
            }

            try
            {
                await provideUserService
                    .Add(addProvideUserModel);

                TempData["message"] = $"You have successfully added a provideUser!";

                return RedirectToAction("AllProvideUsers", "ProvideUser");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(addProvideUserModel);
            }

        }

        public async Task<IActionResult> DetailsProvideUser(int id)
        {

            if (
                await provideUserService
                .GetProvideUserDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var provideUserModel = await
                provideUserService
                .GetProvideUserDetailsById(id);

                return View(provideUserModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditProvideUser(int id)
        {

            if (await provideUserService
                .GetProvideUserDetailsById(id) == null)
            {
                return BadRequest();
            }

            try
            {
                var editFormModel = await
                       provideUserService
                       .EditCreateForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }



        }

        [HttpPost]
        public async Task<IActionResult> EditProvideUser(int id, EditProvideUserModelView editProvideUserModel)
        {

            if (await provideUserService
                .GetProvideUserDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await provideUserService
                    .Edit(id, editProvideUserModel);

                TempData["message"] = $"You have successfully edited a provideUser!";

                return RedirectToAction("AllProvideUsers", "ProvideUser");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(editProvideUserModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteProvideUser(int id)
        {

            if (await provideUserService
                .GetProvideUserDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var editFormModel = await
               provideUserService
               .DeleteProvideUserForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeleteProvideUser(DeleteProvideUserModelView deleteProvideUserModel)
        {

            if (await provideUserService
                .GetProvideUserById(deleteProvideUserModel.ProvideUserId) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await provideUserService
                    .Delete(deleteProvideUserModel.ProvideUserId);

                TempData["message"] = $"You have successfully deleted a provideUser!";

                return RedirectToAction("AllProvideUsers", "ProvideUser");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(deleteProvideUserModel);
            }
        }
    }
}
   