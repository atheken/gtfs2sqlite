using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite.Entities
{
	public class Transfer
	{
		[AutoIncrement]
		public int Id { get; set; }

		public string from_stop_id{ get; set; }
		public string min_transfer_time{ get; set; }
		public string to_stop_id{ get; set; }
		public string transfer_type{ get; set; }
	}
}

