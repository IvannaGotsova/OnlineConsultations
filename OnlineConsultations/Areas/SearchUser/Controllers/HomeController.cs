using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.SearchUser.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
