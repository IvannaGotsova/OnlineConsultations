using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Controllers
{
    public class ProvideUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
