using System;

namespace fileoperation
{
    class Driver
    {
        static void Main(string[] args)
        {
            StreamWriter writeFile = new StreamWriter("D:/temp.txt");
            int lines;
            string s;
            Console.Write("Enter the number of lines you want to insert: ");
            if(int.TryParse(Console.ReadLine(), out lines))
            {
                while (lines-- != 0)
                {
                    s = Console.ReadLine();
                    writeFile.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("Input was not an integer");
                return;
            }
            writeFile.Close();
            Console.WriteLine("Writing Complete");
            StreamReader readFile = new StreamReader("D:/temp.txt");
            Console.WriteLine("Initiating reading");
            s = readFile.ReadLine();
            while(s!= null)
            {
                Console.WriteLine(s);
                s = readFile.ReadLine();
            }
            readFile.Close();
            Console.WriteLine("Reading Complete");
        }

        
    }
}