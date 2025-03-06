using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _02_Razor_Syntax.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }       
    }
}
