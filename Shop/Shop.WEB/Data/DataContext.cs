namespace Shop.WEB.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
	using Shop.WEB.Data.Entities;

	public class DataContext : IdentityDbContext<User>
	{
		public DbSet<Product> Products { get; set; }

		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
	}
}
