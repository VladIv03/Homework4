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
            Console.WriteLine("What symbol do you want to find? ");
            char symbolText = char.ToLower(char.Parse(Console.ReadLine()));
            string smallText = text.ToLower();
            int symbolCount = 0;
            foreach (char c in smallText)

                if (c == symbolText)
                    symbolCount++;

            Console.WriteLine($"number of symbols: {symbolCount} ");

        }
    }
}