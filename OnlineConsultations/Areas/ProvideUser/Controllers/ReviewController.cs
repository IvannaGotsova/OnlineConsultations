using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    [Area("ProvideUser")]
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
