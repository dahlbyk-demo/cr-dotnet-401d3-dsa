using System;
using Challenges.ArrayChallenges;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 2, 3 };

            int[] reversed = ArrayReverse.Reverse(numbers);
            Console.WriteLine("Should be 3,2,1: {0}", string.Join(",", reversed));

            int[] reversed2 = ArrayReverse.Reverse(new[] { 1 });
            Console.WriteLine("Should be 1: {0}", string.Join(",", reversed2));
        }
    }
}
