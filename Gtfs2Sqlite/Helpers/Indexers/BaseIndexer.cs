using System;
using System.Collections.Generic;
using ServiceStack.OrmLite;
using System.Linq;

namespace Gtfs2Sqlite
{
	public abstract class BaseIndexer<T> : IIndexer<T>
	{
		public void AddIndex (string connection)
		{
			var factory = new OrmLiteConnectionFactory (connection, SqliteDialect.Provider);
			using (var db = factory.OpenDbConnection()) {
				using (var transaction = db.BeginTransaction()) {
					db.ExecuteSql ("CREATE INDEX IF NOT EXISTS " + this.GetType ().Name.ToLower () +
						" ON " + typeof(T).Name.ToLower () + "(" +
						GetFieldsToIndex ().Aggregate ("",
						(seed, current) => seed += "," + current).Trim (',') + ");");
					transaction.Commit ();
				}
			}
		}

		protected abstract IEnumerable<String> GetFieldsToIndex ();
	}
}
