using System;

namespace Gtfs2Sqlite
{
	public interface IIndexer<T>
	{
		void AddIndex (string conn);
	}
}

