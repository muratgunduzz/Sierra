using Microsoft.AspNetCore.Mvc;

namespace Sierra.Controllers
{
    public class OurServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
