using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.SearchUser.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
