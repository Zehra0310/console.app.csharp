using System;

class Program
{
    static void Main()
    {
       
     
            Console.Write("Please Enter a Number: ");  
            int number = Convert.ToInt32(Console.ReadLine());

            
            double factorial = Factorial(number);

            
            Console.WriteLine("factorial of " + number + " =" + factorial.ToString());

        
         static double Factorial(int number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;
            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    
    }
    
}