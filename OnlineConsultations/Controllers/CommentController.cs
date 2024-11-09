using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
