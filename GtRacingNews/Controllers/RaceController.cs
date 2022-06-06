using Microsoft.AspNetCore.Mvc;

namespace GtRacingNews.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Result(string Id)
        {
            return View();
        }
    }
}
