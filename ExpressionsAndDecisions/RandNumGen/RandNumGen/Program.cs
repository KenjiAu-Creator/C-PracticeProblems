using System;

namespace RandNumGen
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will generate a random number between 1 and 10.
            // It will then prompt two users for guesses and output whomever is closer to the answer
            // If the guesses are equal distance or the same number, it will result in a draw.

            Console.WriteLine("This program will generate a random number and will take in two guesses. The closer answer is the winner");
            Console.WriteLine("Please choose an integer between 1 and 10");
            
            // User 1 input
            Console.WriteLine("Please input user 1's guess");
            int user1Guess = Convert.ToInt32(Console.ReadLine());
            
            // User 2 input
            Console.WriteLine("Please input user 2's guess");
            int user2Guess = Convert.ToInt32(Console.ReadLine());

            // Creating random number
            Random rnd = new Random();
            int secretNumber = rnd.Next(1,10);

            // Check distance between the three numbers
            int distance1 = Math.Abs(secretNumber - user1Guess);
            int distance2 = Math.Abs(secretNumber - user2Guess);

            int minimumDistance = Math.Min(distance1, distance2);
            if (distance1 == distance2 || user1Guess == user2Guess)
            {
                // Then the result is a draw
                Console.WriteLine("The secret number was " + secretNumber.ToString() + ". The result was a draw.");
            }
            else if (minimumDistance == distance1)
                {
                // Then user 1 is closer
                Console.WriteLine("The secret number was " + secretNumber.ToString() + ". The winner is User 1.");
            }
            else
            {
                //  Then user 2 is closer
                Console.WriteLine("The secret number was " + secretNumber.ToString() + ". The winner is User 2.");
            }

        }
    }
}
