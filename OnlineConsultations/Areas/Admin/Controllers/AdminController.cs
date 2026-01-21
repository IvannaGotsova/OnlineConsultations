using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
