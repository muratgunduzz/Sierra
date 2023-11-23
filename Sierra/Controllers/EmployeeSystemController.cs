using Microsoft.AspNetCore.Mvc;

namespace Sierra.Controllers
{
    public class EmployeeSystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
