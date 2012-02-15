using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMungingKata
{
	public class WeatherDataRows : List<WeatherDataRow>
	{
		public WeatherDataRow GetRowWithSmallestSpread()
		{
			var smallestSpread =
				(from y in this
				 select y.TemperatureSpread)
				 .Min();
			var rowWithSmallestSpread =
				(from y in this
				 where y.TemperatureSpread == smallestSpread
				 select y)
				 .First();
			
			return rowWithSmallestSpread;
		}
	}
}
