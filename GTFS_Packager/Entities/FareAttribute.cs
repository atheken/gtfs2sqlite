using System;

namespace GTFS_Packager
{
	public class FareAttribute
	{
		public string currency_type{ get; set; }
		public string fare_id{ get; set; }
		public string payment_method{ get; set; }
		public string price{ get; set; }
		public string transfer_duration{ get; set; }
		public string transfers{ get; set; }
	}
}

