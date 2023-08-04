using System;
namespace ConsoleApp17
{
    class swapping
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number1=" + " " + num1);
            Console.WriteLine("number2=" + " " + num2);

            SwapNum(ref num1, ref num2);
            Console.WriteLine("Value of number1 and number2 after swapping: ");
            Console.WriteLine("number1=" + " " + num1);
            Console.WriteLine("number2=" + " " + num2);
            Console.ReadLine();


        }
        static void SwapNum( ref int num1,  ref int num2)
        {
            int tempswap =num1;
            num1 = num2;
            num2= tempswap;
            
        }
    }
}