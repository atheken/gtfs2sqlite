using System;
using System.IO;
using System.Reflection;

namespace GTFSPackager
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length == 2) {
				var processor = new GTFSProcessor ();
				processor.Package (args [0], args [1]);
			} else {
				Console.WriteLine (String.Format ("GTFS Packer usage: {0} <gtfs.zip> <output.db>", Assembly.GetExecutingAssembly ().GetName ()));
			}
		}
	}
}
