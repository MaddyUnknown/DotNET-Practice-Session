using System;
using System.IO;

namespace Bubblesort
{
    public class Sort
    {
        public static void BubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
        }
    }

    class Driver
    {
        public static void Main(string[] args)
        {
            try
            {
                string file = File.ReadAllText(@"D:\Programs\C# and .NET\Doubt\D1\Doubt-Session-1\BubbleSort\text\TestText.txt");

                int[] arr = Array.ConvertAll(file.Trim().Split(','), s => int.Parse(s));
                Sort.BubbleSort(arr);
                foreach (var i in arr)
                {
                    Console.Write($"{i} ");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException || ex is ArgumentException)
            {
                Console.WriteLine("Content of the file was not parsable");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured");
                Console.WriteLine(ex.Message);
            }

        }
    }

}