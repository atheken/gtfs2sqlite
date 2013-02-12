using System;
using ServiceStack.DataAnnotations;
using GTFS_Packager;

namespace GTFSPackager.Entities
{
	public class Stop
	{
		private Lazy<int?> _stop_name_lookup;
		private Lazy<int?> _stop_description_lookup;

		public Stop ()
		{
			_stop_name_lookup = new Lazy<int?> (() => SurrogateKeyRegistry<StopName>.GetValueForKey (stop_name));
			_stop_description_lookup = new Lazy<int?> (() => SurrogateKeyRegistry<StopName>.GetValueForKey (stop_desc));
		}

		[AutoIncrement]
		public int Id { get; set; }

		public int stop_id { get; set; }

		public string stop_code { get; set; }

		[Ignore]
		public string stop_name  { get; set; }

		[Ignore]
		public string stop_desc  { get; set; }

		public int? stop_name_id {
			get{ return _stop_name_lookup.Value;}
		}

		public int? stop_description_id {
			get {
				return _stop_description_lookup.Value;
			}
		}

		public float? stop_lat  { get; set; }

		public float? stop_lon  { get; set; }

		public string zone_id  { get; set; }

		public string stop_url  { get; set; }

		public string location_type  { get; set; }

		public string parent_station  { get; set; }

		public string stop_timezone { get; set; }

		public string wheelchair_boarding  { get; set; }
	}
}

