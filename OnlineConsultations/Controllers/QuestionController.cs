using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Models.Question;
using static OnlineConsultations.ErrorConstants.ErrorConstants.GlobalErrorConstants;

namespace OnlineConsultations.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService questionService;

        public QuestionController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllQuestions()
        {
            try
            {
                var questions = await
                    questionService
                   .GetAllQuestions();

                return View(questions);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddQuestion()
        {
            var modelQuestion = await Task.Run(() => new AddQuestionModelView());

            return View(modelQuestion);
        }

        [HttpPost]
        public async Task<IActionResult> AddQuestion(AddQuestionModelView addQuestionModel)
        {

            if (!ModelState.IsValid)
            {
                return View(addQuestionModel);
            }

            try
            {
                await questionService
                    .Add(addQuestionModel);

                TempData["message"] = $"You have successfully added a question!";

                return RedirectToAction("AllQuestions", "Question");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(addQuestionModel);
            }

        }

        public async Task<IActionResult> DetailsQuestion(int id)
        {

            if (
                await questionService
                .GetQuestionDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var questionModel = await
                questionService
                .GetQuestionDetailsById(id);

                return View(questionModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditQuestion(int id)
        {

            if (await questionService
                .GetQuestionDetailsById(id) == null)
            {
                return BadRequest();
            }

            try
            {
                var editFormModel = await
                       questionService
                       .EditCreateForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }



        }

        [HttpPost]
        public async Task<IActionResult> EditQuestion(int id, EditQuestionModelView editQuestionModel)
        {

            if (await questionService
                .GetQuestionDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await questionService
                    .Edit(id, editQuestionModel);

                TempData["message"] = $"You have successfully edited a question!";

                return RedirectToAction("AllQuestions", "Question");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(editQuestionModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteQuestion(int id)
        {

            if (await questionService
                .GetQuestionDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var editFormModel = await
               questionService
               .DeleteQuestionForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeleteQuestion(DeleteQuestionModelView deleteQuestionModel)
        {

            if (await questionService
                .GetQuestionById(deleteQuestionModel.QuestionId) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await questionService
                    .Delete(deleteQuestionModel.QuestionId);

                TempData["message"] = $"You have successfully deleted a question!";

                return RedirectToAction("AllQuestions", "Question");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(deleteQuestionModel);
            }
        }
    }
}
   