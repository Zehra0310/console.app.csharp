using System;
namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 2] { { 3, 7 }, { 4, 9 } };
            Console.WriteLine("array[0,0]=" + array[0, 0]);
            Console.WriteLine("array[0,1]=" + array[0, 1]);
            Console.WriteLine("array[1,0]=" + array[1, 0]);
            Console.WriteLine("array[1,1]=" + array[1, 1]);
            Console.ReadKey();

        }
    }
}