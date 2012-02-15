using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMungingKata
{
	public class WeatherDataRow
	{
		public WeatherDataRow() { }

		public WeatherDataRow(string validLine)
		{
			InputLine = validLine;
			string [] inputLineComponents =
				InputLine.Split(" ".ToCharArray(),
				StringSplitOptions.RemoveEmptyEntries);

			DayNumber = 
				int.Parse(inputLineComponents[0]);
			HighTemperature = 
				int.Parse(inputLineComponents[1]);
			LowTemperature = 
				int.Parse(inputLineComponents[2]);
		}

		public string InputLine { get; private set; }
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
