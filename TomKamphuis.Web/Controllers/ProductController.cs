using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TomKamphuis.Models;
using TomKamphuis.Repositories.Interfaces;

namespace TomKamphuis.Web.Controllers
{
	[Route("api/[controller]")]
	public class ProductController : Controller
	{
		private readonly IProductRepository _productRepository;

		public ProductController(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		[HttpGet("[action]")]
		public IEnumerable<Product> Products()
		{
			return _productRepository.GetProducts();
		}
	}
}