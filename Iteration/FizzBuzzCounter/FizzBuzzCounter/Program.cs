using System;

namespace FizzBuzzCounter
{
  class Program
  {
    static void Main(string[] args)
    {
      // This program will count from 1 to 100.
      // Every number divisible by 3 will be replaced with "Fizz"
      // Every number divisible by 5 will be replaced with "Buzz"
      // Every number divisible by both 3 and 5 will be replaced with "FizzBuzz"
      // This is by extension -> divisible by 15, ( 3 * 5 )

      // Initialize variables
      int fizz = 3;
      int buzz = 5;
      int fizzBuzz = 15;

      // Loop
      for (int i = 1; i <= 100; i++)
      {
        if (i % fizzBuzz == 0)
        {
          Console.WriteLine("FizzBuzz");
        }
        else if (i % buzz == 0)
        {
          Console.WriteLine("Buzz");
        }
        else if (i % fizz == 0)
        {
          Console.WriteLine("Fizz");
        }
        else
          Console.WriteLine(i);
      }
    }
  }
}
