using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sierra.Models;
using System.Data.SqlClient;

namespace Sierra.Controllers
{
    public class BMEmployeeController : Controller
    {
        //[Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
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
