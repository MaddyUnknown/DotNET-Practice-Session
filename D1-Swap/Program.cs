using System;

namespace Swap
{
    class Drive
    {

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        static void Main(string[] args)
        {
            int a, b;
            string input;
            Console.Write("Enter first number: ");
            input = Console.ReadLine();
            try
            {
                a = Convert.ToInt32(input);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.Write("Enter second number: ");
            input = Console.ReadLine();
            try
            {
                b = Convert.ToInt32(input);
            }
            catch(Exception ex)
            {
                Console.WriteLine (ex.Message);
                return;
            }
            Console.WriteLine($"Initial value of a & b: {a}, {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After swap of a & b: {a}, {b}");
            Swap(ref a,ref b);
            Console.WriteLine($"After fuctional swap of a & b: {a}, {b}");

        }
    }
}