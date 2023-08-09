using System;
namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =  { 3, 10, 8, 6, 20 };
            int max =  array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Massivdeki en boyuk qiymet: " + max);
        }
    }
}