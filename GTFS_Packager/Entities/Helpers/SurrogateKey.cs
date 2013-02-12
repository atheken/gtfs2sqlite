using System;
using System.Collections.Generic;
using System.Linq;
using ServiceStack.DataAnnotations;

namespace GTFS_Packager
{
	public abstract class SurrogateKey
	{
		[PrimaryKey]
		public int Id{ get; set; }
		
		public string Name { get; set; }
	}
	
	public class TripName:SurrogateKey
	{
	}

	public class Headsign:SurrogateKey
	{
	}

	public class StopDescription:SurrogateKey
	{
	}

	public class StopName:SurrogateKey
	{
	}

	public class SurrogateKeyRegistry<T> where T:SurrogateKey, new()
	{
		private static SortedDictionary<string, int> _names = new SortedDictionary<string, int> ();

		public static int? GetValueForKey (string key)
		{
			int? retval = null;
			if (!String.IsNullOrWhiteSpace (key)) {
				int outval;
				if (!_names.TryGetValue (key, out outval)) {
					outval = _names.Count;
					_names [key] = outval;
				}
				retval = outval;
			}
			return retval;
		}
		
		public static IEnumerable<T> GetAll ()
		{
			return _names.Select (f => new T (){ Name = f.Key, Id = f.Value});
		}
	}
}

