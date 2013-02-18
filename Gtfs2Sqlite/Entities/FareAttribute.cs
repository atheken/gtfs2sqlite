using System;
using ServiceStack.DataAnnotations;

namespace Gtfs2Sqlite.Entities
{
	public class FareAttribute
	{
		//required
		[PrimaryKey]
		public string fare_id{ get; set; }
		public decimal price { get; set; }
		//this is from a set of 4217 ISO currencies.
		public string currency_type{ get; set; }
		public FarePaymentMethod payment_method{ get; set; }
		//should allow for any number.
		public string transfers{ get; set; }
		public int? transfer_duration{ get; set; }
	}
}

