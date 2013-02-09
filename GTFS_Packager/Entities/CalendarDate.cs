using System;
using ServiceStack.DataAnnotations;

namespace GTFSPackager
{
	public class CalendarDate
	{
		[AutoIncrement]
		public int Id { get; set; }

		public string service_id {
			get;
			set;
		}

		public string date {
			get;
			set;
		}

		public string exception_type {
			get;
			set;
		}
	}
}

