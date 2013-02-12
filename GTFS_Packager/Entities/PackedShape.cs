using System;
using ServiceStack.DataAnnotations;

namespace GTFS_Packager
{
	public class PackedShape
	{
		[PrimaryKey]
		public int ShapeId { get; set; }

		public byte[] Coordinates { get; set; }
	}
}

