using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Models.Post;
using static OnlineConsultations.ErrorConstants.ErrorConstants.GlobalErrorConstants;

namespace OnlineConsultations.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllPosts()
        {
            try
            {
                var posts = await
                    postService
                   .GetAllPosts();

                return View(posts);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddPost()
        {
            var modelPost = await Task.Run(() => new AddPostModelView());

            return View(modelPost);
        }

        [HttpPost]
        public async Task<IActionResult> AddPost(AddPostModelView addPostModel)
        {

            if (!ModelState.IsValid)
            {
                return View(addPostModel);
            }

            try
            {
                await postService
                    .Add(addPostModel);

                TempData["message"] = $"You have successfully added a post!";

                return RedirectToAction("AllPosts", "Post");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(addPostModel);
            }

        }

        public async Task<IActionResult> DetailsPost(int id)
        {

            if (
                await postService
                .GetPostDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var postModel = await
                postService
                .GetPostDetailsById(id);

                return View(postModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditPost(int id)
        {

            if (await postService
                .GetPostDetailsById(id) == null)
            {
                return BadRequest();
            }

            try
            {
                var editFormModel = await
                       postService
                       .EditCreateForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }



        }

        [HttpPost]
        public async Task<IActionResult> EditPost(int id, EditPostModelView editPostModel)
        {

            if (await postService
                .GetPostDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await postService
                    .Edit(id, editPostModel);

                TempData["message"] = $"You have successfully edited a post!";

                return RedirectToAction("AllPosts", "Post");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(editPostModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeletePost(int id)
        {

            if (await postService
                .GetPostDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var editFormModel = await
               postService
               .DeletePostForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(DeletePostModelView deletePostModel)
        {

            if (await postService
                .GetPostById(deletePostModel.PostId) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await postService
                    .Delete(deletePostModel.PostId);

                TempData["message"] = $"You have successfully deleted a post!";

                return RedirectToAction("AllPosts", "Post");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(deletePostModel);
            }
        }
    }
}
  