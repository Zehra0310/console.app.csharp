using System;

namespace ConsoleApp7
{
    class task
    {
        static void Main(string[] args)
        {
            int x = 24;
            int y = 13;
            int z = (x + y) / 2 + y++ + ++y + 2 * (x-- * 4);
            int w = z++ + (w = y) - --w;
            Console.WriteLine("{0} {1} {2} {3}", x, y, w, z);
            Console.ReadLine();


            Console.WriteLine("Hello World");

            Console.ReadKey();
        }
    }
}