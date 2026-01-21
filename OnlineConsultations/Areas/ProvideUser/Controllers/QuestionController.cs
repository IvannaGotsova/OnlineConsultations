using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    [Area("ProvideUser")]
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
