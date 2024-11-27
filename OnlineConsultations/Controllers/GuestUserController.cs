using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Models.GuestUser;
using static OnlineConsultations.ErrorConstants.ErrorConstants.GlobalErrorConstants;

namespace OnlineConsultations.Controllers
{
    public class GuestUserController : Controller
    {
        private readonly IGuestUserService guestUserService;

        public GuestUserController(IGuestUserService guestUserService)
        {
            this.guestUserService = guestUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllGuestUsers()
        {
            try
            {
                var guestUsers = await
                    guestUserService
                   .GetAllGuestUsers();

                return View(guestUsers);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddGuestUser()
        {
            var modelGuestUser = await Task.Run(() => new AddGuestUserModelView());

            return View(modelGuestUser);
        }

        [HttpPost]
        public async Task<IActionResult> AddGuestUser(AddGuestUserModelView addGuestUserModel)
        {

            if (!ModelState.IsValid)
            {
                return View(addGuestUserModel);
            }

            try
            {
                await guestUserService
                    .Add(addGuestUserModel);

                TempData["message"] = $"You have successfully added a guestUser!";

                return RedirectToAction("AllGuestUsers", "GuestUser");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(addGuestUserModel);
            }

        }

        public async Task<IActionResult> DetailsGuestUser(int id)
        {

            if (
                await guestUserService
                .GetGuestUserDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var guestUserModel = await
                guestUserService
                .GetGuestUserDetailsById(id);

                return View(guestUserModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditGuestUser(int id)
        {

            if (await guestUserService
                .GetGuestUserDetailsById(id) == null)
            {
                return BadRequest();
            }

            try
            {
                var editFormModel = await
                       guestUserService
                       .EditCreateForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }



        }

        [HttpPost]
        public async Task<IActionResult> EditGuestUser(int id, EditGuestUserModelView editGuestUserModel)
        {

            if (await guestUserService
                .GetGuestUserDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await guestUserService
                    .Edit(id, editGuestUserModel);

                TempData["message"] = $"You have successfully edited a guestUser!";

                return RedirectToAction("AllGuestUsers", "GuestUser");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(editGuestUserModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteGuestUser(int id)
        {

            if (await guestUserService
                .GetGuestUserDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var editFormModel = await
               guestUserService
               .DeleteGuestUserForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeleteGuestUser(DeleteGuestUserModelView deleteGuestUserModel)
        {

            if (await guestUserService
                .GetGuestUserById(deleteGuestUserModel.GuestUserId) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await guestUserService
                    .Delete(deleteGuestUserModel.GuestUserId);

                TempData["message"] = $"You have successfully deleted a guestUser!";

                return RedirectToAction("AllGuestUsers", "GuestUser");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(deleteGuestUserModel);
            }
        }
    }
}
 