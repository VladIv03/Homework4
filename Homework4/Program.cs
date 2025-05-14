using System;

namespace Homework4
{
    internal static class Program
    {
        public static void Main()
        {
            Task1();


        }

        public static void Task1()
        {
            int[] numbers = new int[50];
            for (int i = 0; i < numbers.Length; i++)

                numbers[i] = i * 2;
            foreach (int i in numbers)
                Console.WriteLine($"Element :{i}");
        }
    }
}