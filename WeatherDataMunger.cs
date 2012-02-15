using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMungingKata
{
	public class WeatherDataMunger
	{
		public bool IsValidDataRowInput(string validInput)
		{
			if (String.IsNullOrEmpty(validInput))
			{
				return false;
			}
			else
			{
				string massagedInput = validInput.TrimStart();
				int placeholderInteger;
				bool startsWithInteger =
					Int32.TryParse(massagedInput[0].ToString(), out placeholderInteger);
				return startsWithInteger;
			}
		}
	}
}
