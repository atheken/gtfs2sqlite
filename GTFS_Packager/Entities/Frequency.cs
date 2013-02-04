using System;

namespace GTFS_Packager
{
	public class Frequency
	{
		public string end_time{ get; set; }
		public string exact_times{ get; set; }
		public string headway_secs{ get; set; }
		public string start_time{ get; set; }
		public string trip_id{ get; set; }
	}
}

