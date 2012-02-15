using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DataMungingKata
{
	[TestFixture]
	public class WeatherDataMungerTests
	{
		[Test]
		public void CanInstantiateTest()
		{
			WeatherDataMunger w = new WeatherDataMunger();

			Assert.That(w, Is.Not.Null);
		}

		[Test]
		public void ValidWeatherDataRowInputStartsWithIntegerTest()
		{
			string validInput = "  1  88";
			WeatherDataMunger w = new WeatherDataMunger();

			bool isValid = w.IsValidDataRowInput(validInput);

			Assert.That(isValid, Is.True);
		}

		[Test]
		public void RowThatDoesNotStartWithIntegerIsInvalidDataRowInputTest()
		{
			string invalidInput = "  Dy MxT";
			WeatherDataMunger w = new WeatherDataMunger();

			bool isValid = w.IsValidDataRowInput(invalidInput);

			Assert.That(isValid, Is.False);
		}

		[Test]
		public void EmptyRowIsInvalidDataRowTest()
		{
			string invalidInput = "";
			WeatherDataMunger w = new WeatherDataMunger();

			bool isValid = w.IsValidDataRowInput(invalidInput);

			Assert.That(isValid, Is.False);
		}
	}
}
