using System;


namespace ConsoleApp18
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Be happy");
            Console.WriteLine("--------------");

            Student S1 = new Student();
            S1.SetName("Zahra");
            Console.WriteLine(S1.GetName());
            S1.Display();
            Console.WriteLine("--------------");
            
            Student S2 = new Student();
            S2.SetName("Zulfiyye");
            Console.WriteLine(S2.GetName());
            S2.Display();
            Console.WriteLine("--------------");

            Student S3 = new Student();
            S3.SetName("Imran");
            Console.WriteLine(S3.GetName());
            S3.Display();
            Console.WriteLine("--------------");
            
            Console.ReadKey();
        }
    }
}