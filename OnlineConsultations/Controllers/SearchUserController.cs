using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Models.SearchUser;
using static OnlineConsultations.ErrorConstants.ErrorConstants.GlobalErrorConstants;

namespace OnlineConsultations.Controllers
{
    public class SearchUserController : Controller
    {
        private readonly ISearchUserService searchUserService;

        public SearchUserController(ISearchUserService searchUserService)
        {
            this.searchUserService = searchUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllSearchUsers()
        {
            try
            {
                var searchUsers = await
                    searchUserService
                   .GetAllSearchUsers();

                return View(searchUsers);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddSearchUser()
        {
            var modelSearchUser = await Task.Run(() => new AddSearchUserModelView());

            return View(modelSearchUser);
        }

        [HttpPost]
        public async Task<IActionResult> AddSearchUser(AddSearchUserModelView addSearchUserModel)
        {

            if (!ModelState.IsValid)
            {
                return View(addSearchUserModel);
            }

            try
            {
                await searchUserService
                    .Add(addSearchUserModel);

                TempData["message"] = $"You have successfully added a searchUser!";

                return RedirectToAction("AllSearchUsers", "SearchUser");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(addSearchUserModel);
            }

        }

        public async Task<IActionResult> DetailsSearchUser(int id)
        {

            if (
                await searchUserService
                .GetSearchUserDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var searchUserModel = await
                searchUserService
                .GetSearchUserDetailsById(id);

                return View(searchUserModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditSearchUser(int id)
        {

            if (await searchUserService
                .GetSearchUserDetailsById(id) == null)
            {
                return BadRequest();
            }

            try
            {
                var editFormModel = await
                       searchUserService
                       .EditCreateForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }



        }

        [HttpPost]
        public async Task<IActionResult> EditSearchUser(int id, EditSearchUserModelView editSearchUserModel)
        {

            if (await searchUserService
                .GetSearchUserDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await searchUserService
                    .Edit(id, editSearchUserModel);

                TempData["message"] = $"You have successfully edited a searchUser!";

                return RedirectToAction("AllSearchUsers", "SearchUser");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(editSearchUserModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteSearchUser(int id)
        {

            if (await searchUserService
                .GetSearchUserDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var editFormModel = await
               searchUserService
               .DeleteSearchUserForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeleteSearchUser(DeleteSearchUserModelView deleteSearchUserModel)
        {

            if (await searchUserService
                .GetSearchUserById(deleteSearchUserModel.SearchUserId) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await searchUserService
                    .Delete(deleteSearchUserModel.SearchUserId);

                TempData["message"] = $"You have successfully deleted a searchUser!";

                return RedirectToAction("AllSearchUsers", "SearchUser");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(deleteSearchUserModel);
            }
        }
    }
}
  