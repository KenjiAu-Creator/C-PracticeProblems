using System;

namespace OddOrEven
{
  class Program
    {
    static void Main(string[] args)
        {
      // This program will take in an integer from the user and display whether it is odd or even.
      Console.WriteLine("This program will take in an integer and display whether it is odd or even.");
      Console.WriteLine("Please enter an integer to determine:");

      // User input for number
      int number = Convert.ToInt32(Console.ReadLine());
      int remainder = number % 2;

      if (remainder == 1)
      {
        // The result is odd
        Console.WriteLine(number.ToString() + " is odd.");
       }
      else
      {
        // The result is even
        Console.WriteLine(number.ToString() + " is even.");
      }
    }
  }
}
