using System;
namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / (1.8);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius* 9)/5 + 32;
        }


        //(32°F − 32) × 5/9 = 0°C
        //(0°C × 9/5) + 32 = 32°F



    }

}

//Create a static class called TempConverter - DONE
//Create 2 methods inside the TempConverter class - DONE
//Name the first method - FahrenheitToCelsius - DONE
//Name the second method - CelsiusToFahrenheit - DONE
//Both methods will have a single parameter of type double - DONE
//Complete the logic so that they properly convert the temperatures
//Call both methods in your Main() method