using System;
using ServiceStack.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using GTFS_Packager;

namespace GTFSPackager.Entities
{
	public class StopTime
	{
		private Lazy<int?> _trip_id_lookup;

		public StopTime ()
		{
			_trip_id_lookup = new Lazy<int?> (() => SurrogateKeyRegistry<TripName>.GetValueForKey (trip_id));
		}

		[AutoIncrement]
		public int Id { get; set; }

		[Ignore]
		public string trip_id	{ get; set; }

		public int? trip {
			get { 
				return _trip_id_lookup.Value;
			}
		}

		[Ignore]
		public string arrival_time{ get; set; }

		[Ignore]
		public string departure_time{ get; set; }

		public short departure {
			get {
				var times = departure_time.Split (':');
				const short minutesPerHour = 60;
				return (short)(short.Parse (times [0]) * minutesPerHour + short.Parse (times [1]));
			}
		}

		public int stop_id{ get; set; }

		[Ignore]
		public string stop_sequence{ get; set; }

		public short? sequence {
			get {
				short? retval = null;
				short parsed;
				if (short.TryParse (stop_sequence, out parsed)) {
					retval = parsed;
				}
				return retval;
			}
		}

		public string stop_headsign{ get; set; }

		public string pickup_type{ get; set; }

		public string drop_off_type{ get; set; }

		[Ignore]
		public double? shape_dist_traveled{ get; set; }
	}
}

