using Microsoft.AspNetCore.Mvc;

namespace MusicWeb1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
