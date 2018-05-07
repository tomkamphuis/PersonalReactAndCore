using System.Collections.Generic;
using System.Linq;
using TomKamphuis.Models;
using TomKamphuis.Repositories.Interfaces;

namespace TomKamphuis.Repositories.Implementations
{
	public class ProductRepository : IProductRepository
	{
		private readonly List<Product> _products = new List<Product>
		{
			new Product
			{
				Id = 1,
				Name = "Funda",
				Description = "Funda is the biggest realtor website in the Netherlands",
				WebsiteUrl = "funda.nl"
			}
		};

		public Product GetProduct(int id)
		{
			return _products.FirstOrDefault(p => p.Id == id);
		}

		public IEnumerable<Product> GetProducts()
		{
			return _products;
		}
	}
}