using Microsoft.AspNetCore.Mvc;
using ST10026525.PROG62112.POE.part1.Data;
using ST10026525.PROG62112.POE.part1.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace ST10026525.PROG62112.POE.part1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            int lecturerId = 1;
            var claims = _context.claims.Where(c => c.LecturerId == lecturerId).ToList();
            return View(claims);
        }

        // Inserting admin dashboard to home controller
        public IActionResult AdminDashboard()
        {
            var claims = _context.claims.Where(c=> c.Status == "Pending").ToList();

            return View(claims);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
