namespace Shop.WEB.Data
{
	using Entities;
	using System.Linq;

	public interface IProductRepository : IGenericRepository<Product>
	{
		IQueryable GetAllWithUsers();
	}

}
