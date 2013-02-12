using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite.Entities
{
	public class Shape
	{
		public string shape_id{ get; set; }

		public double? shape_dist_traveled{ get; set; }

		public double shape_pt_lat{ get; set; }
		public double shape_pt_lon{ get; set; }
		public int shape_pt_sequence{ get; set; }
	}
}

