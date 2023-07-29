using System;


namespace ConsoleApp10
{
    class task10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());



            if (number > 0)
            {
                Console.WriteLine($"{number} is positive");
            }


            if (number < 0)
            {
                Console.WriteLine($"{number} is negative");
            }


            if (number == 0)
            {
                Console.WriteLine("The number is neither positive nor negative");
            }
            
            
            Console.ReadKey();
        }
    }
}