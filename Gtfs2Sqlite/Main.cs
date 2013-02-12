using System;
using System.IO;
using System.Reflection;

namespace Gtfs2Sqlite
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length == 2) {
				var processor = new GTFSProcessor ();
				processor.Package (args [0], args [1]);
			} else {
				Console.WriteLine ("Gtfs2Sqlite usage: Gtfs2Sqlite.exe <gtfs.zip> <output.db>");
			}
		}
	}
}
