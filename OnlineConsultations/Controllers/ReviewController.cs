using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Models.Review;
using static OnlineConsultations.ErrorConstants.ErrorConstants.GlobalErrorConstants;

namespace OnlineConsultations.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService reviewService;

        public ReviewController(IReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllReviews()
        {
            try
            {
                var reviews = await
                    reviewService
                   .GetAllReviews();

                return View(reviews);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddReview()
        {
            var modelReview = await Task.Run(() => new AddReviewModelView());

            return View(modelReview);
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(AddReviewModelView addReviewModel)
        {

            if (!ModelState.IsValid)
            {
                return View(addReviewModel);
            }

            try
            {
                await reviewService
                    .Add(addReviewModel);

                TempData["message"] = $"You have successfully added a review!";

                return RedirectToAction("AllReviews", "Review");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(addReviewModel);
            }

        }

        public async Task<IActionResult> DetailsReview(int id)
        {

            if (
                await reviewService
                .GetReviewDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var reviewModel = await
                reviewService
                .GetReviewDetailsById(id);

                return View(reviewModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditReview(int id)
        {

            if (await reviewService
                .GetReviewDetailsById(id) == null)
            {
                return BadRequest();
            }

            try
            {
                var editFormModel = await
                       reviewService
                       .EditCreateForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }



        }

        [HttpPost]
        public async Task<IActionResult> EditReview(int id, EditReviewModelView editReviewModel)
        {

            if (await reviewService
                .GetReviewDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await reviewService
                    .Edit(id, editReviewModel);

                TempData["message"] = $"You have successfully edited a review!";

                return RedirectToAction("AllReviews", "Review");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(editReviewModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteReview(int id)
        {

            if (await reviewService
                .GetReviewDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var editFormModel = await
               reviewService
               .DeleteReviewForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeleteReview(DeleteReviewModelView deleteReviewModel)
        {

            if (await reviewService
                .GetReviewById(deleteReviewModel.ReviewId) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await reviewService
                    .Delete(deleteReviewModel.ReviewId);

                TempData["message"] = $"You have successfully deleted a review!";

                return RedirectToAction("AllReviews", "Review");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(deleteReviewModel);
            }
        }
    }
}
   