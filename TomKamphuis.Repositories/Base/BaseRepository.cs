using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace TomKamphuis.Repositories.Base
{
	public interface IBaseRepository
	{
		CloudTable GetTableReference(string name);
	}

	public class BaseRepository : IBaseRepository
	{
		private readonly CloudTableClient _tableClient;

		public BaseRepository(string connectionString)
		{
			if (string.IsNullOrEmpty(connectionString)) return;

			var storageAccount = CloudStorageAccount.Parse(connectionString);
			_tableClient = storageAccount.CreateCloudTableClient();
		}

		public CloudTable GetTableReference(string name)
		{
			return _tableClient.GetTableReference(name);
		}
	}
}