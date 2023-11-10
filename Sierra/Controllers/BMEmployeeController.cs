using Microsoft.AspNetCore.Mvc;

namespace Sierra.Controllers
{
    public class BMEmployeeController : Controller
    {
        //index actions
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show(string[] elementShow) 
        {
            int check = 0;
            if(elementShow != null)
            {
                check = 1;
            }
            var response = new
            {
                Check = check,
            };
            return Json(response);
        }
        //BMSyestem actions
        public IActionResult BMSystem()
        {
            return View();
        }
        //HQ actions
        public IActionResult HQ()
        {
            return View();
        }
        //CmdSystem actions
        public IActionResult CmdSystem()
        {
            return View();
        }
    }
}
