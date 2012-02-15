using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DataMungingKata
{
	[TestFixture]
	public class WeatherDataRowTests
	{
		[Test]
		public void SpreadIsHighMinusLowTest()
		{
			WeatherDataRow row = new WeatherDataRow
			{
				LowTemperature = 10,
				HighTemperature = 20
			};

			int spread = row.TemperatureSpread;

			Assert.That(spread, Is.EqualTo(10));
		}

		[Test]
		public void CanParseValidWeatherLineTest()
		{
			string validLine = "   1  88    59    74          53.8       0.00 F       280  9.6 270  17  1.6  93 23 1004.5";

			WeatherDataRow row = 
				new WeatherDataRow(validLine);

			Assert.That(row, Is.Not.Null);
			Assert.That(row.DayNumber, Is.EqualTo(1));
			Assert.That(row.LowTemperature, Is.EqualTo(59));
			Assert.That(row.HighTemperature, Is.EqualTo(88));
		}
	}
}
