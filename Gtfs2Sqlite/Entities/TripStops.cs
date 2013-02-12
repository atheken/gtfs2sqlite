using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite
{
	public class TripStops
	{
		[AutoIncrement]
		public int Id {
			get;
			set;
		}

		public int? TripId {
			get;
			set;
		}

		public byte[] Stops{ get; set; }
	}
}

