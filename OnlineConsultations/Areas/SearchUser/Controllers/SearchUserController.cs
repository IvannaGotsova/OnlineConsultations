using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.SearchUser.Controllers
{
    [Area("SearchUser")]
    public class SearchUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
