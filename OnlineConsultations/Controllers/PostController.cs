using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
