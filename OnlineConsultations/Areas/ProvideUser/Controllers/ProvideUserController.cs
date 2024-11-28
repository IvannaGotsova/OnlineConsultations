using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    public class ProvideUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
