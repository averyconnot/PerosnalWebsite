using Microsoft.AspNetCore.Mvc;
using PerosnalSite.Models;
using System.Diagnostics;

namespace PerosnalSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Projects()
        {
            var projects= new List<(string Title, string Description, string Link)>
                {
                    ("Web Application","A github link that showcases skills learned in MVC ASP.NET Core and Bootstrap.", "https://github.com/MIS-3033/hwk-10---mvc-ef-averyconnot"),
                    ("HTML Application", "A github link to an HTML project where JSON and C# was incorporated", "https://github.com/MIS-3033/hwk-5---consuming-json-averyconnot"),
                    ("Latest Exam Application","A github link that demonstrates my latest exam in MIS 3033", "https://github.com/MIS-3033/exam-2-averyconnot")
                };
            return View(projects);
        }
        public IActionResult Skills()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
