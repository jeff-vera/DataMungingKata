using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMungingKata
{
	public class WeatherDataRow
	{
		public int DayNumber { get; set; }
		public int LowTemperature { get; set; }
		public int HighTemperature { get; set; }

		public int TemperatureSpread {
			get
			{
				return HighTemperature - LowTemperature;
			}
		}
	}
}
