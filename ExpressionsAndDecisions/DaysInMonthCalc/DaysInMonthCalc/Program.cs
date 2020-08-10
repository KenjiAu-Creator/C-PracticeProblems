using System;

namespace DaysInMonthCalc
{
  class Program
  {
    public Boolean LeapYear(int year)
    {
      // This function will return whether a year is a leap year or not
      if (year % 4 == 0)
      {
        if (year % 100 == 0)
        {
          if (year % 400 == 0)
          {
            return true;
          }
          else
          {
            return false;
          }
        }
        else
        {
          return true;
        }
      }
      else
      {
        return false;
      }
    }

    static void Main(string[] args)
    {
      // This program will take in a 3 character month cdoe (case insensitive) and output the full name of that month
      // and the number of days in that month.
      // Use a switch statement

      // Initialize
      Console.WriteLine("This program will calculate the number of days in a month");
      Console.WriteLine("Please enter the 3 character month code:");

      // User input
      string month = Console.ReadLine().ToUpper();

      // Calculate

      switch (month)
      {
        case "JAN":
          {
            string numOfDays = "31";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
        case "FEB":
          {
            Console.WriteLine("What year is it for?");
            string year = Console.ReadLine();

            // Initalize class for leap year function
            Program self = new Program();
            Boolean leapYear = self.LeapYear(Convert.ToInt32(year));
            switch (leapYear)
            {
              case true:
                {
                  string numOfDays = "29";
                  Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
                  break;
                }
              case false:
                {
                  string numOfDays = "28";
                  Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
                  break;
                }
            }
            break;
          }
        case "MAR":
          {
            string numOfDays = "31";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
        case "APR":
          {
            string numOfDays = "30";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
        case "MAY":
          {
            string numOfDays = "31";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
        case "JUN":
          {
            string numOfDays = "30";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
        case "JUL":
          {
            string numOfDays = "31";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
        case "AUG":
          {
            string numOfDays = "31";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
        case "SEP":
          {
            string numOfDays = "30";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
        case "OCT":
          {
            string numOfDays = "31";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
        case "NOV":
          {
            string numOfDays = "30";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
        case "DEC":
          {
            string numOfDays = "31";
            Console.WriteLine("In the month of " + month + ". There is " + numOfDays + " days.");
            break;
          }
      }
    }
  }
}
