using Microsoft.AspNetCore.Mvc;

namespace Educare.Controllers
{
    public class AssistantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
