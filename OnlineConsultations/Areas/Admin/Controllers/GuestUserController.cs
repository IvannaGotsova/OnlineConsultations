using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.Admin.Controllers
{
    public class GuestUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
