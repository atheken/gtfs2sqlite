using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite.Entities
{
	public class Calendar
	{
		[AutoIncrement]
		public int id { get; set; }

		//required
		public string service_id{ get; set; }
		public string start_date{ get; set; }
		public string end_date{ get; set; }
		public byte sunday{ get; set; }
		public byte monday{ get; set; }
		public byte tuesday{ get; set; }
		public byte wednesday{ get; set; }
		public byte thursday{ get; set; }
		public byte friday{ get; set; }
		public byte saturday{ get; set; }
	}
}

