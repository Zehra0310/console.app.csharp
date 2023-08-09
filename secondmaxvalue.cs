using System;
using System.Linq;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 25, 45, 78, 16, 7, 51 };
            int max = array.Max(); 
            int seconMax=array.Where(x=>x<max).Max();

            Console.WriteLine("The second max value in array: " +seconMax);
        }
    }
}