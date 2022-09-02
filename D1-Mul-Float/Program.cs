using System;

namespace MulFloat
{
    class Driver
    {
        static void Main(string[] args)
        {
            float a, b;
            string input;
            Console.Write("Enter first number: ");
            input = Console.ReadLine();
            try
            {
                a = Convert.ToSingle(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.Write("Enter second number: ");
            input = Console.ReadLine();
            try
            {
                b = Convert.ToSingle(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            float result = a * b;
            Console.WriteLine($"The result of multiplication: {result}");

        }
    }
}