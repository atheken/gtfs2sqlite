using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite.Entities
{
	public class Agency
	{
		[AutoIncrement]
		public int id{ get; set; }

		//required
		public string agency_name { get; set; }
		public string agency_url { get; set; }
		public string agency_timezone { get; set; }

		//optional
		public string agency_id { get; set; }
		public string agency_lang { get; set; }
		public string agency_phone { get; set; }
		public string agency_fare_url { get; set; }
	}
}

