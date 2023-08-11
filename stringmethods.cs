using System;
namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();

            Console.WriteLine("Enter a string: ");

            Console.WriteLine("Uppercase:" + phrase.ToUpper());
            Console.WriteLine("Lowercase:" + phrase.ToLower());
            Console.WriteLine("Total characters:" + phrase.Length);
            Console.WriteLine("First 5 characters:" + phrase.Substring(0, 5));
            Console.WriteLine("Last 5 characters: " + phrase.Substring(phrase.Length - 5));

            string wordReplaced = phrase.Replace("a", "*");
            Console.WriteLine("Replace 'a' with '*': " + wordReplaced);

            bool containsCSharp = phrase.Contains("CSharp");
            Console.WriteLine("Contains CSharp: " + (containsCSharp ? "Yes" : "No"));

            Console.WriteLine("Index of 'e': " + phrase.IndexOf('e'));

            string[] words = phrase.Split(" ");
            string sentence = string.Join("-", words);
            foreach (string word in words)
            {
                Console.WriteLine("-"+word);
            }
        }
    }
}