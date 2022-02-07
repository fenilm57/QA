using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Conversion
    {
        private int conversionValue;

        public Conversion()
        {
            conversionValue = 1;
        }

        public Conversion(int value)
        {
            conversionValue = value;
        }
        // Celcius to Fahrenheit
        public double ConvertCelciusToFahrenheit()
        {
            return (conversionValue * 9 / 5) + 32;
        }

        // Celcius to kelvin
        public double ConvertCelciusToKelvin()
        {
            return conversionValue + 273.15;
        }

        // Kelvin to Fahrenheit
        public double ConvertKelvinToFahrenheit()
        {
            return (conversionValue - 273.15) * 9 / 5 + 32;
        }

        // Kelvin to Celsius
        public double ConvertKelvinToCelsius()
        {
            return conversionValue - 273.15;
        }

        // Fahrenheit to Kelvin
        public double ConvertFahrenheitToKelvin()
        {
            return (conversionValue - 32) * 5 / 9 + 273.15;
        }

        // Fahrenheit to Celsius
        public double ConvertFahrenheitToCelsius()
        {
            return (conversionValue - 32) * 5 / 9;
        }
        public int ConversionValue { get => conversionValue; set => conversionValue = value; }
    }
}
