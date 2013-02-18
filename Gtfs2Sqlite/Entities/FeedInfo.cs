using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite.Entities
{
	public class FeedInfo
	{
		[AutoIncrement]
		public int id { get; set; }

		//required
		public string feed_publisher_name{ get; set; }
		public string feed_publisher_url{ get; set; }
		public string feed_lang{ get; set; }

		//optional
		public string feed_start_date{ get; set; }
		public string feed_end_date{ get; set; }
		public string feed_version{ get; set; }
	}
}

