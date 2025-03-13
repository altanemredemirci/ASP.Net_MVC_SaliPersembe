namespace _05_Layout_PartialView_RenderSection.Models
{
	public class Comment
	{
        public int Id { get; set; }
        public string Text { get; set; }
        public string Username { get; set; }
        public DateTime CreateDate { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
