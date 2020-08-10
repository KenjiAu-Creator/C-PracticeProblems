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

      // To do
      // No duplicates


      // Initialize the array
      string[] nameList = new string[] { };
      Program self = new Program();
      Boolean exitCon = false;

      while (exitCon != true)
      {
        Console.WriteLine("Would you like to insert, update, delete, or output from the list of names?");
        Console.WriteLine("--------------------------------------------------------------------------");
        Console.WriteLine("Type exit if you would like to close the program");

        string userInput = Console.ReadLine().ToLower();
        switch (userInput)
        {
          case "insert":
            {
              if (nameList.Length >= 10)
              {
                Console.WriteLine("The list has already reached its maximum amount (10)");
                Console.WriteLine("--------------------------------------------------------------------------");
                break;
              }
              Console.WriteLine("Please enter in the name you would like to add");
              string name = Console.ReadLine().Trim();
              if (name.Length <= 2)
              {
                Console.WriteLine("The name can not be less than 2 characters long!");
                break;
              }
              else if (name.Contains(" "))
              {
                Console.WriteLine("Only one word names are allowed in the list at this time.");
                Console.WriteLine("--------------------------------------------------------------------------");
                break;
              }
              else
              {
                nameList = self.addName(nameList, name);
                break;
              }
            }

          case "update":
            {
              Console.WriteLine("Please enter in the name you would input into the list first");
              string name = Console.ReadLine().Trim();
              if (name.Length <= 2)
              {
                Console.WriteLine("The name can not be less than 2 characters long!");
                Console.WriteLine("--------------------------------------------------------------------------");
                break;
              }
              else if (name.Contains(" "))
              {
                Console.WriteLine("Only one word names are allow in the list at this time.");
                Console.WriteLine("--------------------------------------------------------------------------");
                break;
              }
              else
              {
                nameList = self.updateName(nameList, name);
                break;
              }
            }

          case "delete":
            {
              nameList = self.deleteName(nameList);
              break;
            }

          case "output":
            {
              self.outputName(nameList);
              break;
            }
          case "exit":
            {
              exitCon = true;
              break;
            }
          default:
            {
              Console.WriteLine("Command not recognized. Please try again.");
              Console.WriteLine("                                                             ");
              break;
            }
        }
      }
    }

    public string[] addName(string[] arrayOfNames, string name)
    {
      // This method will take in an Array of strings and a string. 
      // This method will output a new Array with the name added.
      // If the array of names is empty, a new array is made with the inputted name

      // Capitalization code
      List<string> nameList = name.Split(",").ToList();
      nameList[0] = name[0].ToString().ToUpper();
      int nameIndex = 0;
      foreach (char letter in name)
      {
        if (nameIndex == 0)
        {
          nameIndex++;
        }
        else
        {
          nameList.Add(letter.ToString());
          nameIndex++;
        }
      }
      string titleName = string.Join("", nameList);

      // Adding to array
      if (arrayOfNames.Length == 0)
      {
        string[] newArray = new string[] { titleName };
        return newArray;
      }
      else
      {
        // https://stackoverflow.com/questions/202813/adding-values-to-a-c-sharp-array
        // The concat code is used to add two arrays together.
        string[] temp = { titleName };
        string[] newArray = arrayOfNames.Concat(temp).ToArray();

        return newArray;
      }
    }

    public string[] updateName(string[] arrayOfNames, string name)
    {
      // This method will take in an array of strings and a string.
      // This method will update an existing entry in the array with the name supplied

      // Capitalization code
      List<string> nameList = name.Split(",").ToList();
      nameList[0] = name[0].ToString().ToUpper();
      int nameIndex = 0;
      foreach (char letter in name)
      {
        if (nameIndex == 0)
        {
          nameIndex++;
        }
        else
        {
          nameList.Add(letter.ToString());
          nameIndex++;
        }
      }
      string titleName = string.Join("", nameList);

      // First need to ask the user if they want to update by name or by index
      Console.WriteLine("Do you wish to update by index or by name?");
      string userInput = Console.ReadLine();
      switch (userInput)
      {
        case ("index"):
          {
            Console.WriteLine("What index would you like to update?");
            int indexToUpdate = (Convert.ToInt32(Console.ReadLine()) - 1);
            arrayOfNames[indexToUpdate] = titleName;
            return arrayOfNames;
          }
        case ("name"):
          {
            Console.WriteLine("What name would you like to update?");
            string nameToUpdate = Console.ReadLine();
            int indexToUpdate = Array.IndexOf(arrayOfNames, nameToUpdate);
            arrayOfNames[indexToUpdate] = titleName;
            return arrayOfNames;
          }
        default:
          {
            Console.WriteLine("You didnt choose index or name!");
            return arrayOfNames;
          }
      }
    }

    public string[] deleteName(string[] arrayOfNames)
    {
      // This method will take in an array of strings
      // This method will delete the name from the existing array

      // First ask the user if they want to delete by name or index
      Console.WriteLine("Do you wish to delete by index or by name?");
      string userInput = Console.ReadLine();
      int i = -1;
      switch (userInput)
      {
        case ("index"):
          {
            Console.WriteLine("What index would you like to delete?");
            int indexToDelete = (Convert.ToInt32(Console.ReadLine()) - 1);
            var listOfNames = new List<string>();

            foreach (string name in arrayOfNames)
            {
              i++;
              if (i != indexToDelete)
                {
                  listOfNames = listOfNames.Append(name).ToList();
                }
            }
            string[] newArray = listOfNames.ToArray();
            return newArray;
          }
        case ("name"):
          {
            Console.WriteLine("What name would you like to delete?");
            string nameToDelete = Console.ReadLine();
            var listOfNames = new List<string>();
            foreach (string name in arrayOfNames)
            {
              if (name != nameToDelete)
              {
                listOfNames = listOfNames.Append(name).ToList();
              }
            }
            string[] newArray = listOfNames.ToArray();
            return newArray;
          }
        default:
          {
            Console.WriteLine("You didnt choose index or name!");
            return arrayOfNames;
          }
      }
    }

    public void outputName(string[] arrayOfNames)
    {
      // This method will output the array of names in the system
      Console.WriteLine("                                                    ");
      Console.WriteLine("Here is a list of the names currently in the system:");
      int i = 0;
      foreach (string name in arrayOfNames)
      {
        i++;
        Console.WriteLine(i + ". " + name);
      }
      Console.WriteLine("----------------------------------------------------");
    }
  }
}
