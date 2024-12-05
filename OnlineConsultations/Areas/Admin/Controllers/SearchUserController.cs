using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.Admin.Controllers
{
    public class SearchUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
