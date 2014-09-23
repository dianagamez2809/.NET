using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberSystemConverter
{
    public class RomanNumeralConverter
    {
        public string ConvertRomanNumeral(int p)
        {
            if (p < 1 || p > 3000)
            {
                throw new IndexOutOfRangeException(
                  "The number supplied is out of the expected range (1 - 3000).");
            }

            return string.Empty;
        }
    }
}
