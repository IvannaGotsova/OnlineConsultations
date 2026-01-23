using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult PageNotFoundError()
        {
            TempData["message"] = $"Page Not Found!";

            return View();
        }
        public ActionResult UnauthorizedError()
        {
            TempData["message"] = $"Unauthorized!";

            return View();
        }
        public ActionResult InternalServerError()
        {
            TempData["message"] = $"Internal Server!";

            return View();
        }
        public ActionResult GenericError()
        {
            TempData["message"] = $"Generic!";

            return View();
        }
    }
}
