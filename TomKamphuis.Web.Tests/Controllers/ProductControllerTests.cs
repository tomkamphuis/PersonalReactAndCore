using System.Collections.Generic;
using System.Linq;
using Moq;
using TomKamphuis.Models;
using TomKamphuis.Repositories.Interfaces;
using TomKamphuis.Web.Controllers;
using Xunit;

namespace TomKamphuis.Web.Tests.Controllers
{
	public class ProductControllerTests
	{
		private readonly ProductController _controller;

		public ProductControllerTests()
		{
			var mockRepository = new Mock<IProductRepository>();

			mockRepository
				.Setup(p => p.GetProducts())
				.Returns(new List<Product> {new Product {Id = 1, Name = "Funda"}});

			_controller = new ProductController(mockRepository.Object);
		}

		[Fact]
		public void AssertThatProductsIsNotNull()
		{
			var forecasts = _controller.Products();

			Assert.NotNull(forecasts);
		}

		[Fact]
		public void AssertThatProductsContainsOneObject()
		{
			var forecasts = _controller.Products();

			Assert.True(forecasts.Count() == 1);
		}
	}
}