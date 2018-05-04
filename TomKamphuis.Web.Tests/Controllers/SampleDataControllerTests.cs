using System.Linq;
using TomKamphuis.Web.Controllers;
using Xunit;

namespace TomKamphuis.Web.Tests.Controllers
{
	public class SampleDataControllerTests
	{
		private readonly SampleDataController _controller;

		public SampleDataControllerTests()
		{
			_controller = new SampleDataController();
		}

		[Fact]
		public void AssertThatWeatherForecastsIsNotNull()
		{
			var forecasts = _controller.WeatherForecasts();

			Assert.NotNull(forecasts);
		}

		[Fact]
		public void AssertThatWeatherForecastsContainsFiveObjects()
		{
			var forecasts = _controller.WeatherForecasts();

			Assert.True(forecasts.Count() == 5);
		}
	}
}