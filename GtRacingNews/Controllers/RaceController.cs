using Microsoft.AspNetCore.Mvc;

namespace GtRacingNews.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Result(string championshipName)
        {
            if (championshipName == "GT Europe Challenge By Fanatec")
            return Redirect("https://www.gt-world-challenge-europe.com/results");

            if (championshipName == "Super GT")
                return Redirect("https://supergt.net/results?ln=en");

            if (championshipName == "British GT")
                return Redirect("https://www.britishgt.com/results");

            else
            return Redirect("https://www.gtopen.net/en/results/");
        }
    }
}
