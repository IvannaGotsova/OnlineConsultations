using Microsoft.AspNetCore.Mvc;
using OnlineConsultations.Core.Contracts;
using OnlineConsultations.Data.Models.Message;
using static OnlineConsultations.ErrorConstants.ErrorConstants.GlobalErrorConstants;

namespace OnlineConsultations.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService messageService;

        public MessageController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllMessages()
        {
            try
            {
                var messages = await
                    messageService
                   .GetAllMessages();

                return View(messages);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddMessage()
        {
            var modelMessage = await Task.Run(() => new AddMessageModelView());

            return View(modelMessage);
        }

        [HttpPost]
        public async Task<IActionResult> AddMessage(AddMessageModelView addMessageModel)
        {

            if (!ModelState.IsValid)
            {
                return View(addMessageModel);
            }

            try
            {
                await messageService
                    .Add(addMessageModel);

                TempData["message"] = $"You have successfully added a message!";

                return RedirectToAction("AllMessages", "Message");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(addMessageModel);
            }

        }

        public async Task<IActionResult> DetailsMessage(int id)
        {

            if (
                await messageService
                .GetMessageDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var messageModel = await
                messageService
                .GetMessageDetailsById(id);

                return View(messageModel);
            }
            catch (Exception)
            {

                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditMessage(int id)
        {

            if (await messageService
                .GetMessageDetailsById(id) == null)
            {
                return BadRequest();
            }

            try
            {
                var editFormModel = await
                       messageService
                       .EditCreateForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }



        }

        [HttpPost]
        public async Task<IActionResult> EditMessage(int id, EditMessageModelView editMessageModel)
        {

            if (await messageService
                .GetMessageDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await messageService
                    .Edit(id, editMessageModel);

                TempData["message"] = $"You have successfully edited a message!";

                return RedirectToAction("AllMessages", "Message");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(editMessageModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteMessage(int id)
        {

            if (await messageService
                .GetMessageDetailsById(id) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                var editFormModel = await
               messageService
               .DeleteMessageForm(id);

                return View(editFormModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeleteMessage(DeleteMessageModelView deleteMessageModel)
        {

            if (await messageService
                .GetMessageById(deleteMessageModel.MessageId) == null)
            {
                return RedirectToAction("Error", "Home", new { area = "" });
            }

            try
            {
                await messageService
                    .Delete(deleteMessageModel.MessageId);

                TempData["message"] = $"You have successfully deleted a message!";

                return RedirectToAction("AllMessages", "Message");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", somethingWrong);

                return View(deleteMessageModel);
            }
        }
    }
}
  