using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using CsvHelper;
using Ionic;
using Ionic.Zip;
using ServiceStack.OrmLite;
using Mono.Data.Sqlite;

namespace GTFSPackager
{
	public class GTFSProcessor
	{
		private Dictionary<string, Action<String, CsvReader>> _readers;

		public GTFSProcessor ()
		{
			_readers = new Dictionary<string, Action<String, CsvReader>> (){
			{"agency.txt",Process<Agency>},
			{"stops.txt",Process<Stop>},
			{"routes.txt",Process<Route>},
			{"trips.txt",Process<Trip>},
			{"stop_times.txt",Process<StopTime>},
			{"calendar.txt",Process<Calendar>},
			{"calendar_dates.txt",Process<CalendarDate>},
			{"fare_attributes.txt",Process<FareAttribute>},
			{"fare_rules.txt",Process<FareRule>},
			{"shapes.txt",Process<Shape>},
			{"frequencies.txt",Process<Frequency>},
			{"transfers.txt",Process<Transfer>},
			{"feed_info.txt",Process<FeedInfo>}
		};
		}

		public void Package (string sourceUrl, string outputDb)
		{
			//var wc = new WebClient ();
			//var file = wc.OpenRead (sourceUrl);
			//var buffer = new byte[file.Length];
			//file.Read (buffer, 0, buffer.Length);
			try {
				using (var zipFile = ZipFile.Read(sourceUrl)) {
					foreach (var entry in zipFile.Entries) {
						using (var reader  =  entry.OpenReader()) {
							using (var streamReader = new StreamReader(reader)) {

								var csvReader = new CsvReader (streamReader);
								csvReader.Configuration.IsStrictMode = false;
								_readers [entry.FileName] (outputDb, csvReader);
							}
						}

					}
				}
			} catch (Exception ex) {
				Console.WriteLine (ex.Message);
				Console.WriteLine (ex.StackTrace);
			}
		}

		private void Process<T> (string connection, CsvReader reader) where T:class, new()
		{
			var objects = reader.GetRecords<T> ();
			var factory = new OrmLiteConnectionFactory (connection, SqliteDialect.Provider);
			using (var db = factory.OpenDbConnection()) {
				using (var tranny = db.BeginTransaction()) {
					db.CreateTable<T> (true);
					db.InsertAll (objects);
					tranny.Commit ();
				}
			}
		}
	}
}

