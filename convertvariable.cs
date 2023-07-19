using System;

namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            
            int a = 10;
            double a1 = Convert.ToDouble(a);
            Console.WriteLine (a1);

            float b = 5.78f;
            int b1= Convert.ToInt32( b);
            Console.WriteLine(b1);

            string c = "55";
            int c1 = int.Parse(c) ;
            Console.WriteLine(c1);


            bool d = false;
            string d1 = Convert.ToString(d);
            Console.WriteLine(d1);


            double e = 75.5364;
            string e1 = Convert.ToString(e);
            Console.Write(e1);

           
            
            Console.ReadKey();
        }
    }
}