using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult PageNotFoundError()
        {
            return View();
        }
        public ActionResult UnauthorizedError()
        {
            return View();
        }
        public ActionResult InternalServerError()
        {
            return View();
        }
        public ActionResult GenericError()
        {
            return View();
        }
    }
}
