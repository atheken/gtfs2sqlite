using System;

namespace GTFS_Packager
{
	public class StopTime
	{
		public string arrival_time{ get; set; }
		public string departure_time{ get; set; }
		public string stop_id{ get; set; }
		public string trip_id{ get; set; }
		public string stop_sequence{ get; set; }
		public string stop_headsign{ get; set; }
		public string pickup_type{ get; set; }
		public string drop_off_type{ get; set; }
		public string shape_dist_traveled{ get; set; }
	}
}

