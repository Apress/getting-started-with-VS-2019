using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualStudioUnitTesting;

namespace VisualStudioTests
{
    [TestClass]
    public class ConversionHelperTests
    {
        [TestMethod]
        [Timeout(2000)]
        public void Test_Fahrenheit_Calc()
        {
            // arrange - setup 
            var celsius = -7.0;
            var expectedFahrenheit = 19.4;

            // act - test
            var result = ConversionHelpers.ToFahrenheit(celsius);

            // assert - check
            Assert.AreEqual(expectedFahrenheit, result);
        }

        [TestMethod]
        public void Test_Celsius_Calc()
        {
            // arrange - setup 
            var fahrenheit = 50.0;
            var expectedCelsius = 10.0;

            // act - test
            var result = ConversionHelpers.ToCelsius(fahrenheit);

            // assert - check
            Assert.AreEqual(expectedCelsius, result);
        }

        [TestMethod]
        public void Test_Pound_Conversion()
        {
            // arrange - setup 
            var kgs = 20.0;
            var expectedPounds = 44.092;

            // act - test
            var result = ConversionHelpers.ToPounds(kgs);

            // assert - check
            Assert.AreEqual(expectedPounds, Math.Round(result,3));
        }

        [TestMethod]
        public void Test_Kgs_Conversion()
        {
            // arrange - setup 
            var pounds = 20.0;
            var expectedKgs = 9.072;

            // act - test
            var result = ConversionHelpers.ToKgs(pounds);

            // assert - check
            Assert.AreEqual(expectedKgs, Math.Round(result, 3));
        }

        [TestMethod]
        public void Test_Container()
        {
            var containerA = new Container();
            var containerB = containerA.Clone();

            var result = containerA == containerB;

            Assert.IsFalse(result);
        }
    }
}
