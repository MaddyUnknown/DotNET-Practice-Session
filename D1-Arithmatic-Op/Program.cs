using System;

namespace Arithmatic
{
    class Driver
    {
        static void Main(string[] args)
        {
            int a=0, b=0;
            int op=-1;
            Console.WriteLine("Instructions: 0 - Addition, 1 - Subtraction, 2 - Multiplication, 3 - Division, 4 - Modulo, 5 - Increment, 6 - Decrement");
            Console.WriteLine("Enter operation: ");
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.Write("Enter first number: ");

            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            if(op <5 && op >= 0)
            {
                Console.Write("Enter second number: ");
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

            }
            

            switch (op)
            {
                case 0: 
                    Console.WriteLine("Addition Result: " + (a + b) );
                    break;
                case 1:
                    Console.WriteLine("Subtration Result: " + (a - b));
                    break;
                case 2:
                    Console.WriteLine("Multiplication Result: " + (1.0 * a * b));
                    break;
                case 3:
                    Console.WriteLine("Division Result: " + (1.0 * a / b));
                    break;
                case 4:
                    Console.WriteLine("Modulo Result: " + (a % b));
                    break;
                case 5:
                    Console.WriteLine("Increment Result: " + (++a));
                    break;
                case 6:
                    Console.WriteLine("Decrement Result: " + ( --a));
                    break;
                default:
                    Console.WriteLine("The selection operation is not valid!!");
                    break;
            }


        }
    }
}
