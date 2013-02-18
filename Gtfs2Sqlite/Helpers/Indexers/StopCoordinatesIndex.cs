using System;
using ServiceStack.OrmLite;
using System.Collections.Generic;
using Gtfs2Sqlite.Entities;

namespace Gtfs2Sqlite
{
	public class StopCoordinatesIndex : BaseIndexer<Stop>
	{
		protected override IEnumerable<string> GetFieldsToIndex ()
		{
			yield return "stop_lat";
			yield return "stop_lon";
			yield break;
		}
	}
}

