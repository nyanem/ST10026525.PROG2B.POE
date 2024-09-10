using Microsoft.AspNetCore.Mvc;

namespace ST10026525.PROG62112.POE.part1.Controllers
{
    public class LecturerController : Controller
    {
        [HttpPost]
        public IActionResult SubmitClaim(int hoursWorked, decimal hourlyRate, string notes, IFormFile supportingDoc)
        {
            if (supportingDoc != null && supportingDoc.Length > 0)
            {
                if (supportingDoc.Length > 10485760) // 10MB limit
                {
                    ModelState.AddModelError("", "File size should be less than 10MB");
                }

                var allowedExtensions = new[] { ".pdf", ".docx", ".xlsx" };
                var fileExtension = Path.GetExtension(supportingDoc.FileName).ToLower();
                if (!allowedExtensions.Contains(fileExtension))
                {
                    ModelState.AddModelError("", "Invalid file type. Only .pdf, .docx, and .xlsx are allowed.");
                }

                // Proceed with saving file after validation
                // ...
            }
            // This logic is too validate File submitions and upload them to the database
            if (supportingDoc != null && supportingDoc.Length > 0)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwwroot/uploads", supportingDoc.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    supportingDoc.CopyTo(stream);
                }
            }
            //Add code to  Save the claim details to the databse 

            return RedirectToAction("Privacy");
        }
    }
}
