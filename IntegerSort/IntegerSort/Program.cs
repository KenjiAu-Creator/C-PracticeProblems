using System;
using System.ComponentModel.DataAnnotations;

namespace IntegerSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will take in three integers, and determin the highest and lowest of the three
            // 

            // Int 1 input
            Console.WriteLine("Input integer 1");
            int integer1 = Convert.ToInt32(Console.ReadLine());

            // Int 2 input
            Console.WriteLine("Input integer 2");
            int integer2 = Convert.ToInt32(Console.ReadLine());

            // Int 3 input
            Console.WriteLine("Input integer 3");
            int integer3 = Convert.ToInt32(Console.ReadLine());

            // Step 1. This step determines a local maximum
            int max1 = Math.Max(integer1, integer2);

            // Step 2. This step determines the absolute maximum
            int highest = Math.Max(max1, integer3);

            // Step 3. This step determines a local minimum
            int min1 = Math.Min(integer1, integer2);

            // Step 4. This step determines the absolute minimum
            int lowest = Math.Min(min1, integer3);

            Console.WriteLine("The highest value is " + highest);
            Console.WriteLine("The lowest value is " + lowest);
        }
    }
}
