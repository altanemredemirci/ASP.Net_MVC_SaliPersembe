using _03_ViewBag_ViewData_TempData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _03_ViewBag_ViewData_TempData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			//ViewBag.ad = "Altan Emre";

			//Product product = new Product { Id = 1, Name = "Telefon", Price = 70000 };
			//ViewBag.urun = product;


			//ViewData["ad"] = "Altan Emre";
			
            
            //TempData["ad"] = "Altan Emre";


			return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            Product product = new Product { Id = 1, Name = "Telefon", Price = 70000 };
            TempData["ad"] = "Altan Emre";
            return View(product);
        }
    }
}

/*
 ******** CONTROLLER'dan VIEW'e Data Transferi ***********
 *** ViewBag:
    - Ýster tek data, istersek bir nesneyi tanýmlý olduðunu Controller dan View e taþýr. Bu taþýma iþleminin yaþam döngüsü bir transfer süresince olur.
 * ViewData:
    - Ýster tek data, istersek bir nesneyi tanýmlý olduðunu Controller dan View e taþýr. Bu taþýma iþleminin yaþam döngüsü bir transfer süresince olur.
 * TempData
 
 
 
 */