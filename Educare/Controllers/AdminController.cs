using Educare.Data;
using Microsoft.AspNetCore.Mvc;

namespace Educare.Controllers
{
    public class AdminController : Controller
    {
        private readonly EducareDbContext _context;

        public AdminController(EducareDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var userID = HttpContext.Session.GetInt32("UserID");
            var role = HttpContext.Session.GetString("Role");

            // Not logged in
            if (userID == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Logged in but not an admin
            if (role != "Admin")
            {
                return RedirectToAction("Index", "Student");
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
        public IActionResult Students(string search)
        {
            var userID = HttpContext.Session.GetInt32("UserID");
            var role = HttpContext.Session.GetString("Role");

            // Not logged in
            if (userID == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Only admins can access this page
            if (role != "Admin")
            {
                return RedirectToAction("Index", "Student");
            }

            var students = _context.Users
                .Where(u => u.Role == "Student")
                .AsQueryable();

            // Search by name or email
            if (!string.IsNullOrWhiteSpace(search))
            {
                students = students.Where(u =>
                    u.FullName.Contains(search) ||
                    u.Email.Contains(search));
            }

            ViewBag.FullName = HttpContext.Session.GetString("FullName");

            return View(students.ToList());
        }
        public IActionResult Details(int id)
        {
            var userID = HttpContext.Session.GetInt32("UserID");
            var role = HttpContext.Session.GetString("Role");

            // Not logged in
            if (userID == null)
            {
                return RedirectToAction("Login", "Account");
            }

            // Only admins can access student details
            if (role != "Admin")
            {
                return RedirectToAction("Index", "Student");
            }

            var student = _context.Users
                .FirstOrDefault(u => u.UserID == id && u.Role == "Student");

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}
