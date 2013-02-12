using System;
using ServiceStack.DataAnnotations;

namespace GTFSPackager.Entities
{
	public class Frequency
	{
		[AutoIncrement]
		public int Id { get; set; }

		public string end_time{ get; set; }
		public string exact_times{ get; set; }
		public string headway_secs{ get; set; }
		public string start_time{ get; set; }
		public string trip_id{ get; set; }
	}
}

