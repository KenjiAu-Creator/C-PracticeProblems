using System;

namespace PerfSqre
{
  class Program
  {
    static void Main(string[] args)
    {
      // This program will determine whether a number entered by the user is a perfect square of a whole number or not.
      // I could use a int data type approach however this will throw an error when the user wishes to check non int type numbers.
      // By extension though non int type numbers will not be a perfect square anyway.

      // Initialize
      Console.WriteLine("This program will determine your number is a perfect square of a whole number or not.");
      Console.WriteLine("Please enter a number to determine:");

      // User Input
      double userInput = Convert.ToDouble(Console.ReadLine());
      double numberRoot = Math.Sqrt(userInput);

      // Check if the number is whole or not.
      double floor = Math.Floor(numberRoot);
      double diff = (numberRoot - floor);
      if (diff != 0)
      {
        // The number is not a perfect square of a whole.
        Console.Write(userInput.ToString() + " is not a perfect square of a whole number.");
      }
      else
      {
        // The number is a perfect square of a whole.
        Console.WriteLine(userInput.ToString() + " is a perfect square of " + numberRoot.ToString());
      }
    }
  }
}
