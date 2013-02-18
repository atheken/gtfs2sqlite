using System;
using ServiceStack.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using Gtfs2Sqlite;

namespace Gtfs2Sqlite.Entities
{
	public class StopTime
	{
		[AutoIncrement]
		public int id { get; set; }

		//required
		public string trip_id { get; set; }
		//See this for details: https://developers.google.com/transit/gtfs/reference#stop_times_fields
		public string arrival_time { get; set; }
		public string stop_id { get; set; }
		//making an assumption that a trip will have < 512 stops, saves lots of space.
		public byte stop_sequence { get; set; }


		//optional
		public string departure_time { get; set; }
		public string stop_headsign { get; set; }
		public PickupDropoffType? pickup_type { get; set; }
		public PickupDropoffType? drop_off_type { get; set; }
		public float? shape_dist_traveled { get; set; }
	}
}

