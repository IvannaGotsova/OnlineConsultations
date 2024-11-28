using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    public class SearchUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
