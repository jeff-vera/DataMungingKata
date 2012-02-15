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
	}
}
