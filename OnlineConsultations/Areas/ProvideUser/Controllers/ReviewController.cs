using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
