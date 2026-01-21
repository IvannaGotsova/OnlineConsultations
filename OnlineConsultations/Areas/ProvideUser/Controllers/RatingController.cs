using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    [Area("ProvideUser")]
    public class RatingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
