using System;

namespace Gtfs2Sqlite
{
	public class LocationType
	{
		public static readonly bool Stop = false;
		public static readonly bool Station = true;
	}

	public enum RouteType:byte
	{
		Tram_Streetcar_LightRail = 0,
		Subway_Metro = 1,
		Rail = 2,
		Bus = 3,
		Ferry = 4,
		CableCar = 5,
		Gondola = 6,
		Funicular = 7
	}

	public enum WheelchairBoarding : byte
	{
		//there's 6 difference values. a little funky.
	}

	public enum PickupDropoffType : byte
	{
		RegularlyScheduled = 0,
		NotAvailable = 1,
		MustPhoneToArrange = 2,
		MustCoordinateWithDriver = 3
	}

	public enum CalendarExceptionType : byte
	{
		ServiceAdded = 1,
		ServiceRemoved = 2
	}

	public enum FarePaymentMethod
	{
		PaidOnBoard=0,
		PaidBeforeBoarding = 1
	}
}

