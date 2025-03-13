using Microsoft.EntityFrameworkCore;

namespace _05_Layout_PartialView_RenderSection.Models
{
	public class DataContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-58CMK8T\\SQLDERS;Database=EShopper;Integrated Security=True; TrustServerCertificate=True;");
		}


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<BrandCategory>()
				.HasKey(i => new { i.BrandId, i.CategoryId });
		}

		public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
