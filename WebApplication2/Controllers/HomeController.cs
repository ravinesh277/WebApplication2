using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _IConfiguration;


        public HomeController(ILogger<HomeController> logger,IConfiguration ipconfig)
        {
            _logger = logger;
            this._IConfiguration = ipconfig;
        }

        public IActionResult Index()
        {
            ViewData["Greeting"] = _IConfiguration["Greeting"];
            return View();
        }

        public IActionResult Privacy()
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
