using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.SearchUser.Controllers
{
    [Area("SearchUser")]
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
