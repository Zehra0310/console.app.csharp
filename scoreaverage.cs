namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the score for the subject 1: ");
            
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the score for the subject 2: ");
            
            int b= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the score of the subject 3: ");
            
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("The average grade is:");
            Console.WriteLine(FindAverage(a, b, c));



            Console.ReadKey();

        }

        static double FindAverage(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }

    }
}