using System;

namespace ConsoleApp4
{
    class celsiusfaranheit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Celsius:");
            int celsius = Convert.ToInt32(Console.ReadLine());
            
            

            Console.Write("Enter the temperature in Fahrenheit:");
            Console.WriteLine(temperatureconverter(celsius));
            Console.ReadKey();
        }

        static int temperatureconverter(int celsius)
        {

            return (celsius * 9 / 5) + 32;