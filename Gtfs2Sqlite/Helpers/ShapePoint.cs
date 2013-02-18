using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite.Entities
{
	public class ShapePoint
	{
		//required
		public string shape_id{ get; set; }
		public float shape_pt_lat{ get; set; }
		public float shape_pt_lon{ get; set; }
		public int shape_pt_sequence{ get; set; }

		//optional
		public float? shape_dist_traveled{ get; set; }
	}
}

