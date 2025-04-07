using Microsoft.AspNetCore.Mvc;

namespace MusicWeb1.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
