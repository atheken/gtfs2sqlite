using System;
using ServiceStack.DataAnnotations;

namespace GTFSPackager.Entities
{
	public class Shape
	{
		public int shape_id{ get; set; }

		public double? shape_dist_traveled{ get; set; }

		public double shape_pt_lat{ get; set; }
		public double shape_pt_lon{ get; set; }
		public int shape_pt_sequence{ get; set; }
	}
}

