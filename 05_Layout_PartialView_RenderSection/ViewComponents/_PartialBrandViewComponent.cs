using _05_Layout_PartialView_RenderSection.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Layout_PartialView_RenderSection.ViewComponents
{
	public class _PartialBrandViewComponent:ViewComponent
	{
		DataContext db = new DataContext();


		public IViewComponentResult Invoke()
		{
			var brands = db.Brands.ToList();
			return View(brands);
		}
	}
}
