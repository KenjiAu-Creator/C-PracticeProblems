using System;

namespace HypotenuseFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will take in two sides of a right triangle and determine the length of the hypotenuse to 2 decimal places, using the pythagotrean theorem.

            Console.WriteLine("This program will calculate the hypotenuse of a right angle triangle");

            // Length 1
            Console.WriteLine("Please input the length of one side");
            double length1 = Convert.ToDouble(Console.ReadLine());

            // Length 2
            Console.WriteLine("Please input the length of the second side");
            double length2 = Convert.ToDouble(Console.ReadLine());

            // a^2 + b^2 = c^2

            double length3 = Math.Sqrt(Math.Pow(length1,2) + Math.Pow(length2,2));
            Console.WriteLine("The hypotenuse is " + length3);
        }
    }
}
