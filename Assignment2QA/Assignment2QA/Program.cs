using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            string option = "";
            int intValue = 1;
            int intOption = 0;

            // Getting value for conversion from user
            do
            {
                Console.Write("Enter Value to be Converted: ");
                value = Console.ReadLine();

                if (!(int.TryParse(value, out intValue)) || intValue <= 0)
                {
                    Console.WriteLine("Please enter integer number greater than 0");
                }
            } while (!int.TryParse(value, out intValue) || intValue <= 0);

            Conversion c1 = new Conversion(intValue);

            // Option for user
            do
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Select From option below");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Celsius to Kelvin");
                Console.WriteLine("3. Convert Fahrenheit to Celsius");
                Console.WriteLine("4. Convert Fahrenheit to Kelvin");
                Console.WriteLine("5. Convert Kelvin to Celsius");
                Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");
                Console.Write(": ");
                option = Console.ReadLine();

            } while (!int.TryParse(option, out intOption) || (intOption <= 0 || intOption > 7));

            switch (intOption)
            {
                case 1:
                    Console.WriteLine($"Fahrenheit of {intValue}C is {c1.ConvertCelciusToFahrenheit()}F");
                    break;

                case 2:
                    Console.WriteLine($"Kelvin of {intValue}C is {c1.ConvertCelciusToKelvin()}K");
                    break;

                case 3:
                    Console.WriteLine($"Celsius of {intValue}F is {c1.ConvertFahrenheitToCelsius()}C");
                    break;

                case 4:
                    Console.WriteLine($"Kelvin of {intValue}F is {c1.ConvertFahrenheitToKelvin()}K");
                    break;

                case 5:
                    Console.WriteLine($"Celsius of {intValue}K is {c1.ConvertKelvinToCelsius()}C");
                    break;

                case 6:
                    Console.WriteLine($"Fahrenheit of {intValue}K is {c1.ConvertKelvinToFahrenheit()}F");
                    break;

                case 7:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadKey();
        }
    }
}
