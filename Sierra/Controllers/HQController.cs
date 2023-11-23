using Microsoft.AspNetCore.Mvc;

namespace Sierra.Controllers
{
    public class HQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
