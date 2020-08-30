using Microsoft.AspNetCore.Mvc;

namespace SpotifyPro.Controllers
{
    public class vacioController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}