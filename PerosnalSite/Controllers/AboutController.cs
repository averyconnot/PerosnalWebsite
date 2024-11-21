using Microsoft.AspNetCore.Mvc;

namespace PerosnalSite.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
