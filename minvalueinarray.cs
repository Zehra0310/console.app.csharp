using System;
namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 20, 8, 19, 3 };
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                     min= array[i];
                }
            }
            Console.WriteLine("Massivdeki en kicik eded:"+min);
        }
    }
}