using System;
using ServiceStack.DataAnnotations;

namespace GTFS_Packager
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

