﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSystemConverter;

namespace NumberSystemConverter_Tests
{
    [TestClass]
    public class RomanNumeralConverterUpperAndLowerBoundsUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Greater_Than_ThreeThousand_Throws_IndexOutOfRangeException_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(3001);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number_Less_Than_One_Throws_IndexOutOfRangeException_TestMethod()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertRomanNumeral(-1);
        }

    }
}
