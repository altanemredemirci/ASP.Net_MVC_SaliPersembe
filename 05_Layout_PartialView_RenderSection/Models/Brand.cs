namespace _05_Layout_PartialView_RenderSection.Models
{
	public class Brand
	{
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BrandCategory> BrandCategories { get; set; }

	}
}
