using System;

namespace Homework4
{
    internal static class Program
    {
        public static void Main()
        {
            Task2();
        }

        public static void Task2()
        {
            Random random = new Random();
            int[] numbers = new int[33];
            int numsCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 101);
            }
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    numsCount++;
                    Console.Write($"{i}, ");
                }
            }

            Console.WriteLine($"\nAmount of even numbers in this array: {numsCount}");
        }
    }
}