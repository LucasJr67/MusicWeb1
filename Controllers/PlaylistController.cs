using Microsoft.AspNetCore.Mvc;

namespace MusicWeb1.Controllers
{
    public class PlaylistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
