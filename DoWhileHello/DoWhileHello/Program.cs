using System;

namespace DoWhileHello
{
  class Program
  {
    static void Main(string[] args)
    {
      // This program will say "Hello" and wait for input from the user.
      // It will continue saying "Hello" until the user enters "stop" (case insensitive)
      // Use a do-while loop

      // Initialize
      Boolean exit = false;

      do
      {
        Console.WriteLine("Hello");
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "stop")
          {
            exit = true;
          }
      }
      while (exit == false);
    }
  }
}
