using System;

namespace FencePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program will take in a number of fence posts and determine how many buckets of paint will be required to paint the fence posts.
            // The assumption is that one bucket paints four fence posts

            Console.WriteLine("How many fences would you like to paint?");
            int numOfFence = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You will require " + (numOfFence / 4).ToString() + " bucket(s) of paint");
        }
    }
}
