using System;
using ServiceStack.DataAnnotations;
using Gtfs2Sqlite;

namespace Gtfs2Sqlite.Entities
{
	public class Stop
	{

		//required
		[PrimaryKey]
		public string stop_id { get; set; }
		public string stop_name { get; set; }

		// if you need high precision (why?) change these to double.
		public float stop_lat { get; set; }
		public float stop_lon { get; set; }

		//optional
		public string stop_code { get; set; }
		public string stop_desc { get; set; }
		public string zone_id { get; set; }
		public string stop_url { get; set; }
		//this should be configured as a bit.
		public string location_type { get; set; }
		public string parent_station { get; set; }
		public string stop_timezone { get; set; }
		//this should be an enum backed by a byte
		public string wheelchair_boarding { get; set; }
	}
}

