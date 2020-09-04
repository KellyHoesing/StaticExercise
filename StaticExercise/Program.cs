using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What is your Temperature in Celsius?");
            double celsiusInput = double.Parse(Console.ReadLine());
            TempConverter.CelsiusToFarenheit(celsiusInput);
            Console.WriteLine($"Your temperature is {TempConverter.CelsiusToFarenheit(celsiusInput)} degrees Farenheit");

            Console.WriteLine($"What is your Temperature in Farenheit?");
            double farenheitInput = double.Parse(Console.ReadLine());
            TempConverter.FarenheitToCelsius(farenheitInput);
            Console.WriteLine($"Your temperature is {TempConverter.FarenheitToCelsius(farenheitInput)} degrees Celsius");
        }
    }
}
