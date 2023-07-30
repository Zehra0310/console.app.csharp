using System;

namespace ConsoleApp11
{
    class task11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1-7): ");
            int number = int.Parse(Console.ReadLine());

            switch(number)
            { 
            
                case 3:
                Console.WriteLine("Wednesday");
                break;
                
                case 6:
                Console.WriteLine("Saturday");
                break;

                case 9:

                Console.WriteLine("Invalid input.Please enter a number between 1 and 7.");
                break;
            }
            
        }
    }
}