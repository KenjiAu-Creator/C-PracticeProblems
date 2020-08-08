using System;
using System.Reflection.Metadata;

namespace IntegerWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      // This program will prompt the user for an integer and continue prompting until an integer between 1 and 10 is entered.
      // Use a while loop


      // Initialize
      Boolean inputAcceptable = false;
      
      // user input
      while (inputAcceptable != true)
      {
        // Do stuff
        Console.WriteLine("Please input an integer between 1 and 10.");
        int userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput <= 10 && userInput >= 1)
        {
          inputAcceptable = true;
          Console.WriteLine("Thank you.");
        }
        else
        {
          Console.WriteLine("Thats not between 1 and 10!");
        }
      }
    }
  }
}
