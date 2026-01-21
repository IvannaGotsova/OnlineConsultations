using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.SearchUser.Controllers
{
    [Area("SearchUser")]
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
