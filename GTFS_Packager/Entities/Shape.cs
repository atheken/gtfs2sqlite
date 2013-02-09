using System;
using ServiceStack.DataAnnotations;

namespace GTFSPackager
{
	public class Shape
	{
		public string shape_dist_traveled{ get; set; }

		[AutoIncrement]
		public int Id { get; set; }

		public string shape_id{ get; set; }

		public double shape_pt_lat{ get; set; }
		public double shape_pt_lon{ get; set; }
		public string shape_pt_sequence{ get; set; }
	}
}

