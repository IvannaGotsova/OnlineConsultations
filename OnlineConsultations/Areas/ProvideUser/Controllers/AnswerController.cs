using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    [Area("ProvideUser")]
    public class AnswerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
