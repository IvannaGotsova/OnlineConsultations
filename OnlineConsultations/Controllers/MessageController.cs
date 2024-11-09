using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
  