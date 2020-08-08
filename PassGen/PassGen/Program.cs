using System;

namespace PassGen
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will generate a random password that is 5 characters long, consisting of uppercase letters.
            // (Look up how to convert from an integer to a character, and append a character to a string)

            // https://stackoverflow.com/questions/314466/generating-an-array-of-letters-in-the-alphabet
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string pass = "";

            // Rand.Next(Int32, Int32)
            // https://docs.microsoft.com/en-us/dotnet/api/system.random.next?view=netcore-3.1#System_Random_Next_System_Int32_System_Int32_
            Random rnd = new Random();
            for (int i = 0; i <= 5; i++)
            { 
                pass += alphabet[rnd.Next(0, 25)]; 
            }
            // This step is just to check the password
            Console.WriteLine(pass);
        }
    }
}
