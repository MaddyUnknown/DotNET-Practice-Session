using System;

namespace Program
{
    public class TempetatureUtils
    {
        public static float tempCelciusToFarenheit(float tempCelcius)
        {
            float tempFareheit = tempCelcius * 9 / 5 + 32;

            return tempFareheit;
        }

        public static float tempFarenheitToCelcius(float tempFareheit)
        {
            float tempCelcius = (tempFareheit - 32) * 5 / 9;

            return tempCelcius;
        }

    }

    class Driver { 

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

            float tempFarenheit = TempetatureUtils.tempCelciusToFarenheit(tempCelcius);

            Console.WriteLine($"Temperature in Farehenit is: {tempFarenheit}");
            Console.WriteLine($"Temperature in Celcius is: {TempetatureUtils.tempFarenheitToCelcius(tempFarenheit)}");

        }
    }
}