namespace _05_Layout_PartialView_RenderSection.Models
{
	public class Product
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Barcode { get; set; }
        public short Stock { get; set; }
        public short Rating { get; set; }

        public List<Image> Images { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }

		public List<Comment> Comments { get; set; }
    }
}
