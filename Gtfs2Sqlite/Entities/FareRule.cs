using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite.Entities
{
	public class FareRule
	{
		[AutoIncrement]
		public int id { get; set; }

		//required
		public string fare_id { get; set; }

		//optional
		public string route_id{ get; set; }
		public string contains_id{ get; set; }
		public string destination_id{ get; set; }
		public string origin_id{ get; set; }
	}
}

