using System.Collections.Generic;
using System.Threading.Tasks;
using TomKamphuis.Models;

namespace TomKamphuis.Repositories.Interfaces
{
	public interface IProductRepository
	{
		Product GetProduct(string id);
		IEnumerable<Product> GetProducts();
	}
}