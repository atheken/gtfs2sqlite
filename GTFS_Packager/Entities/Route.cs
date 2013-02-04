using System;

namespace GTFS_Packager
{
	public class Route
	{
		public string route_id{ get; set; }
		public string agency_id{ get; set; }
		public string route_short_name{ get; set; }
		public string route_long_name{ get; set; }
		public string route_desc{ get; set; }
		public string route_type{ get; set; }
		public string route_url{ get; set; }
		public string route_color{ get; set; }
		public string route_text_color{ get; set; }
	}
}

