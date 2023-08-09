using System;
namespace ConsoleApp19
{
    class  Arraytask
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sumOfEvenNumbers = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumOfEvenNumbers += number;
                }
            }

            Console.WriteLine("Sum of Even numbers: " + sumOfEvenNumbers);

        }
    }
}