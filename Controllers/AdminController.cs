using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ST10026525.PROG62112.POE.part1.Data;
using ST10026525.PROG62112.POE.part1.Models;

namespace ST10026525.PROG62112.POE.part1.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult AdminDashboard()
        {
            var claims = _context.claims.Where(c => c.Status == "Pending").ToList();

            if (claims == null || !claims.Any())
            {
                claims = new List<Claims>();
            }
            return View(claims);
             
        }
        [HttpPost]
        public async Task<IActionResult> ApproveClaim(int claimId)
        {
            var claim = _context.claims.FirstOrDefault(c => c.ClaimsId == claimId);
            if (claim != null)
            {
                claim.Status = "Approved";
                await _context.SaveChangesAsync();
            }
            return RedirectToAction ("AdminDashboard");
        }

        [HttpPost]
        public async Task<IActionResult> RejectClaim(int claimId)
        {
            var claim = _context.claims.FirstOrDefault(c => c.ClaimsId == claimId);
            if (claim != null)
            {
                claim.Status = "Rejected";
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("AdminDashboard");
        }
    }
}

