using Microsoft.AspNetCore.Mvc;

namespace Educare.Controllers
{
    public class CareersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
