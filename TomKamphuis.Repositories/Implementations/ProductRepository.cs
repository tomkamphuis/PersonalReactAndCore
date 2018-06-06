using System.Collections.Generic;
using TomKamphuis.Models;
using TomKamphuis.Repositories.Interfaces;
using Microsoft.WindowsAzure.Storage.Table;
using TomKamphuis.Repositories.Base;

namespace TomKamphuis.Repositories.Implementations
{
	public class ProductRepository : IProductRepository
	{
		private const string TableName = "Products";
		private const string PartitionKey = "Product";

		private readonly CloudTable _table;

		public ProductRepository(IBaseRepository baseRepository)
		{
			_table = baseRepository.GetTableReference(TableName);
		}

		public Product GetProduct(string id)
		{
			return (Product)_table.ExecuteAsync(TableOperation.Retrieve<Product>(PartitionKey, id)).Result.Result;
		}

		public IEnumerable<Product> GetProducts()
		{
			var query = new TableQuery<Product>()
				.Where(TableQuery.GenerateFilterCondition(Constants.PartitionKey, QueryComparisons.Equal, PartitionKey));
			
			return _table.ExecuteQuerySegmentedAsync(query, null).Result;
		}
	}
}