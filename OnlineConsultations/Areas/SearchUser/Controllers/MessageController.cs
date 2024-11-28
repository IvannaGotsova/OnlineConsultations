using Microsoft.AspNetCore.Mvc;

namespace OnlineConsultations.Areas.SearchUser.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
