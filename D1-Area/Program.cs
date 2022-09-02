using System;

namespace Program
{
    class Driver
    {
        static float areaSquare(float sideLength)
        {
            return sideLength * sideLength;

        }

        static float areaCircle(float radius)
        {
            return (float) (2 * Math.PI * radius);

        }

        static float areaRectangle(float length, float width)
        {
            return length * width;

        }

        private static bool allNotNegative(params float[] parameters)
        {
            foreach(float f in parameters)
            {
                if(f < 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Instruction: 0 - Area of Circle, 1 - Area of Square, 2 - Area of Rectangle");
            Console.Write("Enter you Choice: ");
            int choice;

            if(! (int.TryParse(Console.ReadLine(), out choice)))
            {
                Console.WriteLine("Invalid format of argument");
                return;
            }

            if(choice == 0)
            {
                float radius;
                Console.Write("Enter the radius of the circle in cm: ");
                if(float.TryParse(Console.ReadLine(), out radius) && allNotNegative(radius))
                {
                    Console.WriteLine($"The area of the circle with radius {radius} cm is {areaCircle(radius)} sq. cm");
                }
                else
                {
                    Console.WriteLine("Invalid input argument: radius");
                }
            }
            else if(choice == 1)
            {
                float sideLength;
                Console.Write("Enter the length of side of square in cm: ");
                if (float.TryParse(Console.ReadLine(), out sideLength) && allNotNegative(sideLength))
                {
                    Console.WriteLine($"The area of the sqare with side of {sideLength} cm is {areaSquare(sideLength)} sq. cm");
                }
                else
                {
                    Console.WriteLine("Invalid input argument: sideLength");
                }
            }
            else if(choice == 2)
            {
                float length, breadth;
                Console.Write("Enter the length and bread of square in cm (seperated by a space) : ");
                string[] input = Console.ReadLine().Trim().Split(' ');
                if (input.Length == 2 && (float.TryParse(input[0], out length)) && (float.TryParse(input[1], out breadth)) && allNotNegative(length, breadth))
                {
                    Console.WriteLine($"The area of the rectangle is {areaRectangle(length, breadth)} sq. cm");
                }
                else
                {
                    Console.WriteLine("Invalid parameter length or Invalid input argument: length | breadth");
                }
            }
            else
            {
                Console.WriteLine("Not a valid choice");
            }
        }

    }
    
}