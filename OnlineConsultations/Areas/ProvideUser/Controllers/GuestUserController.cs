using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    [Area("ProvideUser")]
    public class GuestUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
