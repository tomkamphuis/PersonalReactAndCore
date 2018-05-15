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
				Name = "Snappet",
				Description = "Our mission is to improve learning outcome of children worldwide. We do this by developping multiple applications that support each other.",
				WebsiteUrl = "snappet.org"
			},
			new Product
			{
				Id = 2,
				Name = "Funda",
				Description = "Funda is the biggest realtor website in the Netherlands",
				WebsiteUrl = "funda.nl"
			},
			new Product
			{
				Id = 3,
				Name = "Transavia",
				Description = "Transavia b2c was focussed on creating the new award winning platform to help people book their flight",
				WebsiteUrl = "transavia.com"
			},
			new Product
			{
				Id = 4,
				Name = "DTG",
				Description = "Setting up the website used in their new b2b strategy",
				WebsiteUrl = "dtg.nl"
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