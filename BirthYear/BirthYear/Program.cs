using System;

namespace BirthYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will take in a user's age and calculate their birth year 
            // (assuming this year's birthday has passed)

            DateTime localDate = DateTime.Now;
            Console.WriteLine("Enter in your age");
            int age = Convert.ToInt32(Console.ReadLine());
            int birthYear = localDate.Year - age;

            Console.WriteLine(birthYear);
        }
    }
}
