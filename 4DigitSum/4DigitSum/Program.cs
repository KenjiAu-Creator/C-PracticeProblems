using System;

namespace _4DigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will take in a 4 digit integer and calculate the sum of its
            // digits without ever converting the integer to a string

            // First idea is to divide original by 1000, save to result1
            // Subtract original with result1, then divide by 100, save to result2
            // Subtract result1 with result2, then divide by 10, save to result3
            // Subtract result2 with result 3, save to result4
            // Sum all results
            // Since data type is int we do not need to round.

            Console.WriteLine("Input 4 digit to be summed");
            int originalNumber = Convert.ToInt32(Console.ReadLine());
            
            // Step one
            int thousandth = (originalNumber / 1000);
            int secondNumber = originalNumber - (thousandth * 1000);

            // Step two
            int hundredth = (secondNumber / 100);
            int thirdNumber = secondNumber - (hundredth * 100);

            // Step three
            int tenth = (thirdNumber / 10);
            int fourthNumber = thirdNumber - (tenth * 10);

            // Step four
            
            // Result
            int result = thousandth + hundredth + tenth + fourthNumber;
            Console.WriteLine(result);
        }
    }
}
