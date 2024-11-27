using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Models.Rating;
using static OnlineConsultations.ErrorConstants.ErrorConstants.GlobalErrorConstants;

namespace OnlineConsultations.Controllers
{
    public class RatingController : Controller
    {
        private readonly IRatingService ratingService;

        public RatingController(IRatingService ratingService)
        {
            this.ratingService = ratingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllRatings()
        {
            try
            {
                var ratings = await
                    ratingService
                   .GetAllRatings();

                return View(ratings);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddRating()
        {
            var modelRating = await Task.Run(() => new AddRatingModelView());

            return View(modelRating);
        }

        [HttpPost]
        public async Task<IActionResult> AddRating(AddRatingModelView addRatingModel)
        {

            if (!ModelState.IsValid)
            {
                return View(addRatingModel);
            }

            try
            {
                await ratingService
                    .Add(addRatingModel);

                TempData["message"] = $"You have successfully added a rating!";

                return RedirectToAction("AllRatings", "Rating");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(addRatingModel);
            }

        }

        public async Task<IActionResult> DetailsRating(int id)
        {

            if (
                await ratingService
                .GetRatingDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var ratingModel = await
                ratingService
                .GetRatingDetailsById(id);

                return View(ratingModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditRating(int id)
        {

            if (await ratingService
                .GetRatingDetailsById(id) == null)
            {
                return BadRequest();
            }

            try
            {
                var editFormModel = await
                       ratingService
                       .EditCreateForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }



        }

        [HttpPost]
        public async Task<IActionResult> EditRating(int id, EditRatingModelView editRatingModel)
        {

            if (await ratingService
                .GetRatingDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await ratingService
                    .Edit(id, editRatingModel);

                TempData["message"] = $"You have successfully edited a rating!";

                return RedirectToAction("AllRatings", "Rating");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(editRatingModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRating(int id)
        {

            if (await ratingService
                .GetRatingDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var editFormModel = await
               ratingService
               .DeleteRatingForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeleteRating(DeleteRatingModelView deleteRatingModel)
        {

            if (await ratingService
                .GetRatingById(deleteRatingModel.RatingId) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await ratingService
                    .Delete(deleteRatingModel.RatingId);

                TempData["message"] = $"You have successfully deleted a rating!";

                return RedirectToAction("AllRatings", "Rating");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(deleteRatingModel);
            }
        }
    }
}
   