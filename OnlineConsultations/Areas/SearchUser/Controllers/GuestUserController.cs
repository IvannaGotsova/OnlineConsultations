using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.SearchUser.Controllers
{
    public class GuestUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
