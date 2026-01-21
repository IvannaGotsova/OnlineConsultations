using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.SearchUser.Controllers
{
    [Area("SearchUser")]
    public class ProvideUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
