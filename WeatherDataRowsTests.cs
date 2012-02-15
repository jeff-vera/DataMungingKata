using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DataMungingKata
{
	[TestFixture]
	public class WeatherDataRowsTests
	{
		[Test]
		public void CanDetermineSmallestSpreadCorrectlyTest()
		{
			WeatherDataRows rows = new WeatherDataRows {
				new WeatherDataRow { 
					DayNumber= 1, 
					LowTemperature = 10, 
					HighTemperature = 20 
				},
				new WeatherDataRow { 
					DayNumber= 2, 
					LowTemperature = 11, 
					HighTemperature = 20 
				},
				new WeatherDataRow { 
					DayNumber= 3, 
					LowTemperature = 12, 
					HighTemperature = 20 
				}
			};

			WeatherDataRow rowWithSmallestSpread =
				rows.GetRowWithSmallestSpread();

			Assert.That(rowWithSmallestSpread, 
				Is.Not.Null);
			Assert.That(rowWithSmallestSpread.DayNumber,
				Is.EqualTo(3));
		}
	}
}
