using System;

namespace ConsoleApp9
{
    class task
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 5;
            int c = 4;
            int d = 3;
            int e = 2;
            int result = a-- * --b + e++ / c - ++d / a * b++ - --e * c;
            Console.WriteLine("Initial Values: ");
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"d: {d}");
            Console.WriteLine($"e: {e}");
            Console.WriteLine($"result: {result}");

            Console.WriteLine("\nExpressıon Result:");


            Console.WriteLine($"a-- * --b + e++ / c - ++d / a * b++ - --e * c;");
            Console.ReadKey();
        }
    }
}