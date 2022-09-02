using System;

namespace Program
{
    class Drive
    {

        static float distanceFeetToMeter(float distanceFeet)
        {
            float distanceMeter = distanceFeet*0.3048f;

            return distanceMeter;
        }

        static void Main(string[] args)
        {
            float distanceFeet;
            Console.Write("Enter Distance in Feet: ");
            try
            {
                distanceFeet = Convert.ToSingle(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine($"Distance in Meter is: {distanceFeetToMeter(distanceFeet)}");

        }
    }
}