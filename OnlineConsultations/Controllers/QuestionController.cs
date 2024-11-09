using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
   