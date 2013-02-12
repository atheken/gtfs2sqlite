using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite
{
	public class PackedShape
	{
		[PrimaryKey]
		public int? ShapeId { get { return SurrogateKeyRegistry<ShapeName>.GetValueForKey (ShapeName); } }

		public string ShapeName { get; set; }

		public byte[] Coordinates { get; set; }
	}
}

