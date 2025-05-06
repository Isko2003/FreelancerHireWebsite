using System.Diagnostics;
using FreelancerHireWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerHireWebsite.Controllers
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
        public IActionResult Work()
        {
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult FreelancerDashboard()
        {
            return View();
        }
        public IActionResult ClientDashboard()
        {
            return View();
        }
        public IActionResult AdminDashboard()
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
