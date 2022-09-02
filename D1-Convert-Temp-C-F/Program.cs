using System;

namespace Program
{
    class Driver
    {
        static float tempCelciusToFarenheit(float tempCelcius)
        {
            float tempFareheit = tempCelcius * 9 / 5 + 32;

            return tempFareheit;
        }

        static float tempFarenheitToCelcius(float tempFareheit)
        {
            float tempCelcius = (tempFareheit - 32) * 5 / 9;

            return tempCelcius;
        }

        static void Main(string[] args)
        {
            float tempCelcius;
            Console.Write("Enter Temperature in Celcius: ");
            try
            {
                tempCelcius = Convert.ToSingle(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            float tempFarenheit = tempCelciusToFarenheit(tempCelcius);

            Console.WriteLine($"Temperature in Farehenit is: {tempFarenheit}");
            Console.WriteLine($"Temperature in Celcius is: {tempFarenheitToCelcius(tempFarenheit)}");

        }
    }
}