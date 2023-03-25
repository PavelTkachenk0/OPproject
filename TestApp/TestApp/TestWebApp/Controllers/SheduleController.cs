using Microsoft.AspNetCore.Mvc;

namespace TestWebApp.Controllers
{
    public class SheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
