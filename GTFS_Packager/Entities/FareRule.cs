using System;
using ServiceStack.DataAnnotations;

namespace GTFSPackager
{
	public class FareRule
	{
		[AutoIncrement]
		public int Id {
			get;
			set;
		}
		public string contains_id{ get; set; }
		public string destination_id{ get; set; }
		public string fare_id{ get; set; }
		public string origin_id{ get; set; }
		public string route_id{ get; set; }
	}
}

