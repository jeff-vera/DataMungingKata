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
	}
}
