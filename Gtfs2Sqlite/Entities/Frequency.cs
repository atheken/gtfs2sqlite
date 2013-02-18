using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite.Entities
{
	public class Frequency
	{
		[AutoIncrement]
		public int id { get; set; }

		//required
		public string trip_id{ get; set; }
		public string start_time{ get; set; }
		public string end_time{ get; set; }
		public string headway_secs{ get; set; }

		//optional
		public string exact_times{ get; set; }
	}
}

