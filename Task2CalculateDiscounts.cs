using System;

namespace Week6Workshop
{
    // Delegates
    public delegate int Calculate(int a, int b);
    public delegate double DiscountStrategy(double price);

    public class Task2CalculateDiscounts
    {
        // Calculation methods
        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;

        // Discount methods
        static double FestivalDiscount(double price) => price * 0.80;
        static double SeasonalDiscount(double price) => price * 0.90;
        static double NoDiscount(double price) => price;

        public static double CalculateFinalPrice(double original, DiscountStrategy strategy)
            => strategy(original);

        public static void Run()
        {
            Console.WriteLine("\n--- TASK 2: Calculate & DiscountStrategy ---\n");

            // Demonstrate Calculate delegate
            Calculate calc = Add;
            Console.WriteLine("Calculation:");
            Console.WriteLine($"10 + 5 = {calc(10, 5)}");

            calc = Subtract;
            Console.WriteLine($"10 - 5 = {calc(10, 5)}");
            Console.WriteLine(new string('-', 40));

            // Demonstrate DiscountStrategy
            double price = 1000;
            Console.WriteLine("Discounts on Original Price: 1000");
            Console.WriteLine($"Festival Discount (20% off) : {CalculateFinalPrice(price, FestivalDiscount):C}");
            Console.WriteLine($"Seasonal Discount (10% off) : {CalculateFinalPrice(price, SeasonalDiscount):C}");
            Console.WriteLine($"No Discount                  : {CalculateFinalPrice(price, NoDiscount):C}");
            Console.WriteLine($"Lambda 30% Discount          : {CalculateFinalPrice(price, p => p * 0.70):C}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
