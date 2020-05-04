namespace Shop.WEB.Data
{
	using Microsoft.EntityFrameworkCore;
	using Shop.WEB.Data.Entities;

	public class DataContext : DbContext
	{
		public DbSet<Product> Products { get; set; }

		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
	}
}
