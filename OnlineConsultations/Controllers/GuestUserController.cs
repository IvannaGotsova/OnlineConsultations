using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Controllers
{
    public class GuestUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
 