using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    [Area("ProvideUser")]
    public class SearchUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
