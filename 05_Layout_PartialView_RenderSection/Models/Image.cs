namespace _05_Layout_PartialView_RenderSection.Models
{
	public class Image
	{
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
