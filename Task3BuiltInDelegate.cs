using System;

namespace Week6Workshop
{
    public class Task3BuiltInDelegate
    {
        // Method to process numbers based on a condition
        static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var n in numbers)
            {
                if (condition(n))
                    Console.WriteLine(n);
            }
        }

        public static void Run()
        {
            Console.WriteLine("\n--- TASK 3: Built-in Delegate ---\n");

            int[] nums = { 1, 4, 11, 20, 3, 14 };

            Console.WriteLine("Even Numbers:");
            ProcessNumbers(nums, n => n % 2 == 0);
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Numbers > 10:");
            ProcessNumbers(nums, n => n > 10);
            Console.WriteLine(new string('-', 30));
        }
    }
}
