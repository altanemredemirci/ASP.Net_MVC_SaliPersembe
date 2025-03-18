using _05_Layout_PartialView_RenderSection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _05_Layout_PartialView_RenderSection.Controllers
{
    public class HomeController : Controller
    {
		DataContext db = new DataContext();
        public IActionResult Index()
        {
			var model = db.Products.Include(i=>i.Images).Where(i=> i.Rating>3).ToList();
            return View(model);
        }

		public IActionResult Products()
		{
			var products = db.Products.Include("Images").ToList();
			return View(products);
		}

		public IActionResult ProductDetail(int id)
		{
			var product = db.Products.Include(i => i.Images).Include(i=> i.Brand).FirstOrDefault(i => i.Id == id);
			return View(product);
		}
	}
}
