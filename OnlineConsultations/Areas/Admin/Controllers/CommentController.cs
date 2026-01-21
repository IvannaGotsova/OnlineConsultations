using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
