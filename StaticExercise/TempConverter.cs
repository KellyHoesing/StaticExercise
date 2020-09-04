using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FarenheitToCelsius(double farenheit)
        {
            var result = (farenheit - 32) / 1.8;
            return result;
        }
        public static double CelsiusToFarenheit(double celsius)
        {
            var result = celsius * 1.8 + 32;
            return result;
        }

    }
}
