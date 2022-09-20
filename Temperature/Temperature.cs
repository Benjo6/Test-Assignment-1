using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureKata
{
    public class Temperature
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            if (celsius <= -273.15)
                throw new ArgumentException($"Invalid temperature value in Celsius: {celsius}");
            return Math.Round((celsius * 1.8) + 32, 2);
        }

        public double CelsiusToKelvin(double celsius)
        {
            if (celsius <= -273.15)
                throw new ArgumentException($"Invalid temperature value in Celsius: {celsius}");
            return Math.Round(celsius + 273.15, 2);
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            if (fahrenheit <= -459.67)
                throw new ArgumentException($"Invalid temperature value in Fahrenheit: {fahrenheit}");
            return Math.Round((fahrenheit-32)*5/9, 2);
        }

        public double FahrenheitToKelvin(double fahrenheit)
        {
            if (fahrenheit <= -459.67)
                throw new ArgumentException($"Invalid temperature value in Fahrenheit: {fahrenheit}");
            return Math.Round((fahrenheit-32)*5/9 + 273.15, 2);
        }

        public double KelvinToCelsius(double kelvin)
        {
            if (kelvin <= 0)
                throw new ArgumentException($"IT GOES AGAINST LORD KELVIN... Invalid temperature value in Kelvin: {kelvin}");
            return Math.Round(kelvin - 273.15, 2);
        }

        public double KelvinToFahrenheit(double kelvin)
        {
            if(kelvin <= 0)
                throw new ArgumentException($"IT GOES AGAINST LORD KELVIN... Invalid temperature value in Kelvin: {kelvin}");
            return Math.Round((kelvin - 273.15) * 1.8 + 32, 2);
        }
    }
}
