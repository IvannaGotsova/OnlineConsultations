using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.SearchUser.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
