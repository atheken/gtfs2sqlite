using System;
using ServiceStack.DataAnnotations;
using GTFS_Packager;

namespace GTFSPackager.Entities
{
	public class Trip
	{
		private Lazy<int?> _surrogate_key_lookup;
		private Lazy<int?> _trip_headsign_lookup;

		public Trip ()
		{
			_surrogate_key_lookup = new Lazy<int?> (() => {
				return SurrogateKeyRegistry<TripName>.GetValueForKey (this.trip_id);
			});

			_trip_headsign_lookup = new Lazy<int?> (() => {
				return SurrogateKeyRegistry<Headsign>.GetValueForKey (trip_headsign);
			});

		}
		[AutoIncrement]
		public int Id{ get; set; }

		public string trip_id{ get; set; }

		public int? surrogate_key {
			get {
				return _surrogate_key_lookup.Value;
			}
		}

		public string block_id{ get; set; }
		public string direction_id{ get; set; }
		public string route_id{ get; set; }
		public string service_id{ get; set; }
		public int? shape_id{ get; set; }

		[Ignore]
		public string trip_headsign{ get; set; }

		public int? trip_headsign_id { 
			get { 
				return _trip_headsign_lookup.Value;
			}
		}

		public string trip_short_name{ get; set; }
		public string wheelchair_accessible{ get; set; }
	}
}

