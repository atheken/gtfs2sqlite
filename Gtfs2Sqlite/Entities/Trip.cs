using System;
using ServiceStack.DataAnnotations;
using Gtfs2Sqlite;

namespace Gtfs2Sqlite.Entities
{
	public class Trip
	{

		[AutoIncrement]
		public int Id{ get; set; }

		public string trip_id{ get; set; }

		public int? surrogate_key {
			get {
				return  SurrogateKeyRegistry<TripName>.GetValueForKey (this.trip_id);
			}
		}

		public string block_id{ get; set; }
		public string direction_id{ get; set; }
		public string route_id{ get; set; }
		public string service_id{ get; set; }

		[Ignore]
		public string shape_id{ get; set; }

		public int? shape_name { get { return SurrogateKeyRegistry<ShapeName>.GetValueForKey (shape_id); } }

		[Ignore]
		public string trip_headsign{ get; set; }

		public int? trip_headsign_id { 
			get { 
				return SurrogateKeyRegistry<Headsign>.GetValueForKey (trip_headsign);
			}
		}

		public string trip_short_name{ get; set; }

		public string wheelchair_accessible{ get; set; }
	}
}

