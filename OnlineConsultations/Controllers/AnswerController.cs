using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Models.Answer;
using static OnlineConsultations.ErrorConstants.ErrorConstants.GlobalErrorConstants;

namespace OnlineConsultations.Controllers
{
    public class AnswerController : Controller
    {
 
        private readonly IAnswerService answerService;

        public AnswerController(IAnswerService answerService)
        {
            this.answerService = answerService;
        }
      
        public IActionResult Index()
        {
            return View();
        }
       
        public async Task<IActionResult> AllAnswers()
        {
            try
            {
                var answers = await
                    answerService
                   .GetAllAnswers();

                return View(answers);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddAnswer()
        {
            var modelAnswer = await Task.Run(() => new AddAnswerModelView());
           
            return View(modelAnswer);
        }
       
        [HttpPost]
        public async Task<IActionResult> AddAnswer(AddAnswerModelView addAnswerModel)
        {
            
            if (!ModelState.IsValid)
            {
                return View(addAnswerModel);
            }

            try
            {
                await answerService
                    .Add(addAnswerModel);

                TempData["message"] = $"You have successfully added a answer!";

                return RedirectToAction("AllAnswers", "Answer");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(addAnswerModel);
            }

        }
      
        public async Task<IActionResult> DetailsAnswer(int id)
        {
           
            if (
                await answerService
                .GetAnswerDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var answerModel = await
                answerService
                .GetAnswerDetailsById(id);

                return View(answerModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }
  
        [HttpGet]
        public async Task<IActionResult> EditAnswer(int id)
        {
          
            if (await answerService
                .GetAnswerDetailsById(id) == null)
            {
                return BadRequest();
            }

            try
            {
                var editFormModel = await
                       answerService
                       .EditCreateForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }



        }
   
        [HttpPost]
        public async Task<IActionResult> EditAnswer(int id, EditAnswerModelView editAnswerModel)
        {
          
            if (await answerService
                .GetAnswerDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await answerService
                    .Edit(id, editAnswerModel);

                TempData["message"] = $"You have successfully edited a answer!";

                return RedirectToAction("AllAnswers", "Answer");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(editAnswerModel);
            }
        }
      
        [HttpGet]
        public async Task<IActionResult> DeleteAnswer(int id)
        {
           
            if (await answerService
                .GetAnswerDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var editFormModel = await
               answerService
               .DeleteAnswerForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }
       
        [HttpPost]
        public async Task<IActionResult> DeleteAnswer(DeleteAnswerModelView deleteAnswerModel)
        {

            if (await answerService
                .GetAnswerById(deleteAnswerModel.AnswerId) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await answerService
                    .Delete(deleteAnswerModel.AnswerId);

                TempData["message"] = $"You have successfully deleted a answer!";

                return RedirectToAction("AllAnswers", "Answer");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(deleteAnswerModel);
            }
        }
    }
}
 