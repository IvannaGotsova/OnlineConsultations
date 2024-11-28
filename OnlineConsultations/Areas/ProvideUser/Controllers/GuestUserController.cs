using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    public class GuestUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
