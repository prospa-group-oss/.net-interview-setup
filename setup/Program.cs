using System;

namespace setup
{
    public static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please type in your name.");

            var name = Console.ReadLine();

            Console.WriteLine($"Hi {name}, you're setup!");
        }
    }
}
