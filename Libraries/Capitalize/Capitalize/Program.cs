using System;

namespace Capitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will take in a string and convert it to uppercase
            Console.WriteLine("Input a string to convert to uppercase");
            string word = Console.ReadLine();
            string value = word.ToUpper();
            Console.WriteLine(value);
        }
    }
}
