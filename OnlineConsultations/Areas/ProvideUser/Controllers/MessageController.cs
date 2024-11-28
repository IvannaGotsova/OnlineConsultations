using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.ProvideUser.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
