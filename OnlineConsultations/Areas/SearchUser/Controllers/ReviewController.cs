using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.SearchUser.Controllers
{
    [Area("SearchUser")]
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
