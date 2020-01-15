using System.IO;

namespace Elasticsearch.Net
{
	/// <summary>
	/// A factory for creating memory streams using a recyclable pool of <see cref="MemoryStream" /> instances
	/// </summary>
	public class RecyclableMemoryStreamFactory : IMemoryStreamFactory
	{
		private readonly RecyclableMemoryStreamManager _manager;

		public RecyclableMemoryStreamFactory()
		{
			const int blockSize = 1024;
			const int largeBufferMultiple = 1024 * 1024;
			const int maxBufferSize = 16 * largeBufferMultiple;
			_manager = new RecyclableMemoryStreamManager(blockSize, largeBufferMultiple, maxBufferSize)
			{
				AggressiveBufferReturn = true,
				MaximumFreeLargePoolBytes = maxBufferSize * 4,
				MaximumFreeSmallPoolBytes = 100 * blockSize
			};
		}

		public MemoryStream Create() => _manager.GetStream();

		public MemoryStream Create(byte[] bytes) => _manager.GetStream(string.Empty, bytes, 0, bytes.Length);
	}
}
