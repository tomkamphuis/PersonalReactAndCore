using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace TomKamphuis.Models
{
	public class Product : ITableEntity
	{
		public void ReadEntity(IDictionary<string, EntityProperty> properties, OperationContext operationContext)
		{
			Description = properties["Description"].StringValue;
			WebsiteUrl = properties["Website"].StringValue;
		}

		public IDictionary<string, EntityProperty> WriteEntity(OperationContext operationContext)
		{
			throw new NotImplementedException();
		}

		public string PartitionKey { get; set; }
		public string RowKey { get; set; }
		public DateTimeOffset Timestamp { get; set; }
		public string ETag { get; set; }

		public string Name => RowKey;
		public string Description { get; set; }
		public string PhotoUrl { get; set; }
		public string WebsiteUrl { get; set; }
	}
}