using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ListOfNames
{
  class Program
  {
    static void Main(string[] args)
    {
      // This program will allow the user to insert, update, delete or output from a list of single word names (Max 10)
      // If the user wants to update or delete, ask them if they would like to update/delete via name or index number.
      // Display indices starting at 1.
      // Do not allow duplicate names or names that are more than one word in length.
      // Do not allow names under two characters in length, nor only whitespace. Remove all leading and trailing whitespace from names entered.
      // Ensure all names are stored in the array are title case, but inputs / searchs are case insensitive

      // Initialize the array
      string[] nameList = new string[] { };
      Program self = new Program();
      Console.WriteLine("Would you like to insert, update, delete, or output from the list of names?");

      string userInput = Console.ReadLine().ToLower();
      switch (userInput)
      {
        case "insert":
          {
            Console.WriteLine("Please enter in the name you would like to add");
            string name = Console.ReadLine();
            string[] nameList2 = self.addName(nameList, name);
            break;
          }

        case "update":
          {
            break;
          }

        case "delete":
          {
            break;
          }

        case "output":
          {
            break;
          }
      }
    }

    public string[] addName(string[] arrayOfNames, string name)
    {
      // This method will take in an Array of strings and a string. 
      // This method will output a new Array with the name added.
      // If the array of names is empty, a new array is made with the inputted name

      if (arrayOfNames.Length == 0)
      {
        string[] newArray = new string[] { name };
        return newArray;
      }
      else
      {
        // https://stackoverflow.com/questions/202813/adding-values-to-a-c-sharp-array
        // The concat code is used to add two arrays together.
        string[] temp = { name };
        string[] newArray = arrayOfNames.Concat(new string[] { name }).ToArray();

        return newArray;
      }
    }

    public string[] updateName(string[] arrayOfNames, string name)
    {

    }
  }
}
