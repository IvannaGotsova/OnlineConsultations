using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    [Area("ProvideUser")]
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
