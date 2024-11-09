using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Controllers
{
    public class ApplicationUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
