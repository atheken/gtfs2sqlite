using System;
using ServiceStack.DataAnnotations;
using Gtfs2Sqlite;

namespace Gtfs2Sqlite.Entities
{
	public class Trip
	{
		//required
		[PrimaryKey]
		public string trip_id{ get; set; }
		public string route_id { get; set; }
		public string service_id { get; set; }

		//optional
		public string trip_headsign{ get; set; }
		public string trip_short_name{ get; set; }
		public string direction_id{ get; set; }
		public string block_id{ get; set; }
		public string shape_id{ get; set; }
		public string wheelchair_accessible{ get; set; }
	}
}

