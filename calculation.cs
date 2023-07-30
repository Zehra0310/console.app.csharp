using System;


namespace ConsoleApp12
{
    class task12
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.Write("Enter the operation number (1-4): ");
            int operationnumber = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            switch (operationnumber)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                        Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid operation number.");
                    return;

            }

            Console.WriteLine($"Result:{result}");


        }
    }
}