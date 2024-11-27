using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Models.Comment;
using static OnlineConsultations.ErrorConstants.ErrorConstants.GlobalErrorConstants;

namespace OnlineConsultations.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllComments()
        {
            try
            {
                var comments = await
                    commentService
                   .GetAllComments();

                return View(comments);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddComment()
        {
            var modelComment = await Task.Run(() => new AddCommentModelView());

            return View(modelComment);
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(AddCommentModelView addCommentModel)
        {

            if (!ModelState.IsValid)
            {
                return View(addCommentModel);
            }

            try
            {
                await commentService
                    .Add(addCommentModel);

                TempData["message"] = $"You have successfully added a comment!";

                return RedirectToAction("AllComments", "Comment");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(addCommentModel);
            }

        }

        public async Task<IActionResult> DetailsComment(int id)
        {

            if (
                await commentService
                .GetCommentDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var commentModel = await
                commentService
                .GetCommentDetailsById(id);

                return View(commentModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditComment(int id)
        {

            if (await commentService
                .GetCommentDetailsById(id) == null)
            {
                return BadRequest();
            }

            try
            {
                var editFormModel = await
                       commentService
                       .EditCreateForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }



        }

        [HttpPost]
        public async Task<IActionResult> EditComment(int id, EditCommentModelView editCommentModel)
        {

            if (await commentService
                .GetCommentDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await commentService
                    .Edit(id, editCommentModel);

                TempData["message"] = $"You have successfully edited a comment!";

                return RedirectToAction("AllComments", "Comment");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(editCommentModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteComment(int id)
        {

            if (await commentService
                .GetCommentDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var editFormModel = await
               commentService
               .DeleteCommentForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeleteComment(DeleteCommentModelView deleteCommentModel)
        {

            if (await commentService
                .GetCommentById(deleteCommentModel.CommentId) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await commentService
                    .Delete(deleteCommentModel.CommentId);

                TempData["message"] = $"You have successfully deleted a comment!";

                return RedirectToAction("AllComments", "Comment");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(deleteCommentModel);
            }
        }
    }
}
 