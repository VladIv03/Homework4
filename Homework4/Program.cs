using System;

namespace Homework4
{
    internal static class Program
    {
        public static void Main()
        {
            Task3();
        }

        public static void Task3()
        {
            Console.Write("Enter your string: ");
            string text = Console.ReadLine();
            foreach (char c in text) ;
            Console.WriteLine($"This string contains: {text.Length} characters ");
        }
    }
}