using System.Collections.Generic;
using TomKamphuis.Models;

namespace TomKamphuis.Repositories.Interfaces
{
	public interface IProductRepository
	{
		Product GetProduct(int id);
		IEnumerable<Product> GetProducts();
	}
}