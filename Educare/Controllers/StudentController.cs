using Microsoft.AspNetCore.Mvc;

namespace Educare.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var userID = HttpContext.Session.GetInt32("UserID");

            // If the student isn't logged in, send them back to Login
            if (userID == null)
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.FullName = HttpContext.Session.GetString("FullName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login", "Account");
        }
    }
}
