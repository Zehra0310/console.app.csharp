using System;
namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n=int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i<n; i++)
            {
                Console.Write("Enter the number{0}: " , i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average =(double) sum / n;
            Console.WriteLine("Array average: "+average);
        }
    }
}
