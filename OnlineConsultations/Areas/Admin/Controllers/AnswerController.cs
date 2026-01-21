using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnswerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
