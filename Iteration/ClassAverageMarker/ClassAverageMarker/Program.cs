using System;
using System.Collections.Generic;

namespace ClassMarker
{
  class Program
  {
    static void Main(string[] args)
    {
      // This program will prompt for up to 20 marks. The program will prompt for marks
      // until the user has entered all 20 marks or enters a -1. Ensure that the user
      // enters at least 1 mark. When done output the average, highest, and lowest mark from the class.
      // Once finished, ask if they want to start again.
      // If they enter any integer that is not between -1 and 100, prompt again and disregard the last input.

      // Initialize
      Boolean allTests = false;
      
      // Information learned on list creation
      // https://www.tutorialsteacher.com/csharp/csharp-list
      List<int> scores = new List<int>();

      // Score gathering
      while (allTests != true) 
      {
        // We are prompting for 20 marks
        Console.WriteLine("Please enter in a mark");
        int mark = Convert.ToInt32(Console.ReadLine());

        if ((scores.Count == 0) && mark == -1)
        {
          Console.WriteLine("No marks have been inputted. Please enter atleast one.");
        }
        else if ((mark == -1) || (scores.Count == 20))
        {
          allTests = true;
        }
        else
        {
          scores.Add(mark);
        }
      }

      // Class Calculations
      // Initialization
      int classSize = scores.Count;
      int scoreSum = 0;
      int highest = scores[0];
      int lowest = scores[0];

      for (int i = 0; i <= (classSize - 1); i++)
      {
        scoreSum += scores[i];

        if (highest <= scores[i])
        {
          highest = scores[i];
        }

        if (lowest >= scores[i])
        {
          lowest = scores[i];
        }
      }

      int average = scoreSum / classSize;

      Console.WriteLine("The average of the class is " + average.ToString());
      Console.WriteLine("The highest mark of the class is " + highest.ToString());
      Console.WriteLine("The lowest mark of the class is " + lowest.ToString());
    }
  }
}
