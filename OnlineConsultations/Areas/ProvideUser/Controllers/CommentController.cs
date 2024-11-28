using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
