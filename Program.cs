using System;
namespace StaticExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fahrenheight = TempConvertor.CelsiusToFahrenheit(20);
            var celsius = TempConvertor.FahrenheitToCelsius(68);

            Console.WriteLine($"F is {fahrenheight}, C is {celsius}");
        }
    }
}