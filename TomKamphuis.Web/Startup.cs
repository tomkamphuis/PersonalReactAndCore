using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TomKamphuis.Repositories.Base;
using TomKamphuis.Repositories.Implementations;
using TomKamphuis.Repositories.Interfaces;
using TomKamphuis.Web.Resources;

namespace TomKamphuis.Web
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			
			services.AddSingleton<IBaseRepository>(new BaseRepository(GetConnectionString()));
			services.AddTransient<IProductRepository, ProductRepository>();
		}

		private string GetConnectionString()
		{
			var tokenProvider = new AzureServiceTokenProvider();

			try
			{
				var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(tokenProvider.KeyVaultTokenCallback));
				var secret = keyVaultClient.GetSecretAsync(Environment.GetEnvironmentVariable(Constants.KeyvaultEndpoint)).Result;
				return secret.Value;
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			ConfigureDevelopmentOptions(app, env);
			app.UseStaticFiles();
			SetRoutes(app);
		}

		private static void ConfigureDevelopmentOptions(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
				{
					HotModuleReplacement = true,
					ReactHotModuleReplacement = true
				});
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
			}
		}

		private static void SetRoutes(IApplicationBuilder app)
		{
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");

				routes.MapSpaFallbackRoute(
					name: "spa-fallback",
					defaults: new {controller = "Home", action = "Index"});
			});
		}
	}
}
