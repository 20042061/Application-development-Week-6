using System;

namespace Week6Workshop
{
    public class Task3BuiltInDelegate
    {
        static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var n in numbers)
                if (condition(n))
                    Console.WriteLine(n);
        }

        public static void Run()
        {
            Console.WriteLine("\n--- TASK 3: Built-in Delegate ---");

            int[] nums = { 1, 4, 11, 20, 3, 14 };

            Console.WriteLine("Even Numbers:");
            ProcessNumbers(nums, n => n % 2 == 0);

            Console.WriteLine("Numbers > 10:");
            ProcessNumbers(nums, n => n > 10);
        }
    }
}
