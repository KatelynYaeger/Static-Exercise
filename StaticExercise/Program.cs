using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(32);
            Console.WriteLine($"Celsius {celsius}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(0);
            Console.WriteLine($"Fahrenheit {fahrenheit}");
        }
    }
}

//Create a static class called TempConverter - DONE
//Create 2 methods inside the TempConverter class - DONE
//Name the first method - FahrenheitToCelsius - DONE
//Name the second method - CelsiusToFahrenheit - DONE
//Both methods will have a single parameter of type double - DONE
//Complete the logic so that they properly convert the temperatures - DONE
//Call both methods in your Main() method - DONE
