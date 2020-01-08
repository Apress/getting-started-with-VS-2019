using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VisualStudioUnitTesting
{
    public static class ConversionHelpers
    {
        private const double F_MULTIPLIER = 1.8;
        private const int F_ADDITION = 32;
        private const double POUND_FACTOR = 0.45359237;

        public static double ToFahrenheit(double celsius)
        {
            //Thread.Sleep(2500);
            return celsius * F_MULTIPLIER + F_ADDITION;
        }

        public static double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - F_ADDITION) * 5 / 9;
        }

        public static double ToPounds(double kgs)
        {
            return kgs / POUND_FACTOR;
        }

        public static double ToKgs(double pounds)
        {
            return pounds * POUND_FACTOR;
        }        
    }
}
