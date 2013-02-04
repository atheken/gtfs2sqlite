using System;
using System.Net;
using Ionic;
using Ionic.Zip;
using System.IO;
using System.Collections.Generic;
using CsvHelper;

namespace GTFS_Packager
{
	public class GTFS_Processor
	{
		private Dictionary<string, Action<String, CsvReader>> _readers;

		public GTFS_Processor ()
		{
			_readers = new Dictionary<string, Action<String, CsvReader>> (){
			{"agency.txt",ProcessAgencies},
			{"stops.txt",ProcessStops},
			{"routes.txt",ProcessRoutes},
			{"trips.txt",ProcessTrips},
			{"stop_times.txt",ProcessStopTimes},
			{"calendar.txt",ProcessCalendar},
			{"calendar_dates.txt",ProcessCalendarDates},
			{"fare_attributes.txt",ProcessAttributes},
			{"fare_rules.txt",ProcessFareRules},
			{"shapes.txt",ProcessShapes},
			{"frequencies.txt",ProcessFrequencies},
			{"transfers.txt",ProcessTransfers},
			{"feed_info.txt",ProcessFeedInfo}
		};
		}

		public void Package (string sourceUrl, string outputDb)
		{
			var wc = new WebClient ();
			var file = wc.OpenRead (sourceUrl);

			using (var zipFile = ZipFile.Read(file)) {
				foreach (var entry in zipFile.Entries) {
					using (var reader  =  entry.OpenReader()) {
						using (var streamReader = new StreamReader(reader)) {

							var csvReader = new CsvReader (streamReader);
							_readers [entry.FileName] (outputDb, csvReader);
						}
					}

				}
			}
		}
	
		private void ProcessAgencies (string connection, CsvReader reader)
		{
		}
		private void ProcessStops (string connection, CsvReader reader)
		{
		}
		private void ProcessRoutes (string connection, CsvReader reader)
		{
		}
		private void ProcessTrips (string connection, CsvReader reader)
		{
		}
		private void ProcessStopTimes (string connection, CsvReader reader)
		{
		}
		private void ProcessCalendar (string connection, CsvReader reader)
		{
		}
		private void ProcessCalendarDates (string connection, CsvReader reader)
		{
		}
		private void ProcessAttributes (string connection, CsvReader reader)
		{
		}
		private void ProcessFareRules (string connection, CsvReader reader)
		{
		}
		private void ProcessShapes (string connection, CsvReader reader)
		{
		}
		private void ProcessFrequencies (string connection, CsvReader reader)
		{
		}
		private void ProcessTransfers (string connection, CsvReader reader)
		{
		}
		private void ProcessFeedInfo (string connection, CsvReader reader)
		{
		}
	}
}

