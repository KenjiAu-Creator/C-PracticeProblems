using System;
using System.Globalization;

namespace dinnerSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that will take in a dollar value (as a double) and a number of diners (as an int) and calculate the amount of the bill that each diner should pay (equal split)

            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";

            Console.WriteLine("Input bill total");
            var bill = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input number of diners");
            var diners = Convert.ToInt32(Console.ReadLine());

            double payment = bill / diners;
            Console.WriteLine(payment);
        }
    }
}
