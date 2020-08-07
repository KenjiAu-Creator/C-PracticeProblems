using System;


namespace IntegerSort
{
    class Program
    {
        public static void Sort(Array array, int index, int length);

        static void Main(string[] args)
        {
            // This program will take in three integers, and determin the highest and lowest of the three
            // 

            // Int 1
            Console.WriteLine("Input integer 1");
            int integer1 = Convert.ToInt32(Console.ReadLine());

            // Int 2
            Console.WriteLine("Input integer 2");
            int integer2 = Convert.ToInt32(Console.ReadLine());

            // Int 3
            Console.WriteLine("Input integer 3");
            int integer3 = Convert.ToInt32(Console.ReadLine());

            int[] numbers = {integer1, integer2, integer3 };

            Array.Sort.(numbers, 0, 3);

            DisplayValues(numbers);
        }
    }
}
