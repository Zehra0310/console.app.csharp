using System;

namespace ConsoleApp14
{
    class task
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your numerical score: ");
            double score = Convert.ToDouble(Console.ReadLine());
            string result = score > 90 && score <= 100 ? "A" :
                            score > 80 && score <= 89.99 ? "B" :
                            score > 70 && score <= 79.99 ? "C" :
                            score > 60 && score <= 69.99 ? "D" :
                            score >= 0 && score <= 59.99 ? "F" : "Invalid score";
            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}
