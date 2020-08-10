using System;
using System.Linq.Expressions;

namespace SimpleCalc
{
  class Program
  {
    static void Main(string[] args)
    {
      // This program will take in an operator (Such as + or *) and two operands (as ints) and output the result.
      // Ensure that division produces accurate results -> decimals and therefore the answer is not of type int
      
      // Input operator
      Console.WriteLine("What type of operation would you like to do? (+, - , *, / )");
      string op = Console.ReadLine();
      
      // Input int 1
      Console.WriteLine("Enter in integer 1:");
      int integer1 = Convert.ToInt32(Console.ReadLine());

      // Input int 2
      Console.WriteLine("Enter in integer 2:");
      int integer2 = Convert.ToInt32(Console.ReadLine());

      // Actual calculation

      switch (op)
      {
        case ("+"):
          int result = (integer1 + integer2);
          Console.WriteLine("The resultant is " + result.ToString());
          break;
        case ("-"):
          result = (integer1 - integer2);
          Console.WriteLine("The resultant is " + result.ToString());
          break;
        case ("*"):
          result = (integer1 * integer2);
          Console.WriteLine("The resultant is " + result.ToString());
          break;
        case ("/"):
          while (integer2 == 0)
            {
              Console.WriteLine("You can not divide by 0! Please enter in a new divisor");
              integer2 = Convert.ToInt32(Console.ReadLine());
            }
          double resultant = Math.Round((Convert.ToDouble(integer1) / Convert.ToDouble(integer2)), 3);
          Console.WriteLine("The resultant is " + resultant.ToString());
          break;
        default:
          Console.WriteLine("Sorry this calculator does not support that operation");
          break;
        }
      }
    }
  }
