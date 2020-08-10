using System;
using System.Security.Cryptography;

namespace PracticeProb1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please input a number");
            int userNum = Convert.ToInt32(Console.ReadLine());
            double pow_ab = Math.Pow(userNum, 3);
            Console.WriteLine(pow_ab);

            //Citation
            //https://www.geeksforgeeks.org/c-sharp-math-pow-method/
            // double is the type of data
            // pow_ab is variable name
            // Math.pow( base , power)
            // pow_ab = base ^^ power or pow_ab = a ^^ b
        }
    }
}
