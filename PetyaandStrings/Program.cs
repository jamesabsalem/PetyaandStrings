using System;

namespace PetyaandStrings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var x = Console.ReadLine().ToLower();
            var y = Console.ReadLine().ToLower();
            if (string.CompareOrdinal(x, y) < 0)
                Console.WriteLine(-1);
            if (string.CompareOrdinal(x, y) == 0)
                Console.WriteLine(0);
            if (string.CompareOrdinal(x, y) > 0)
                Console.WriteLine(1);
        }
    }
}