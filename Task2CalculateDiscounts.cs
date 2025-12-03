using System;

namespace Week6Workshop
{
    public delegate int Calculate(int a, int b);
    public delegate double DiscountStrategy(double price);

    public class Task2CalculateDiscounts
    {
        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;

        static double FestivalDiscount(double price) => price * 0.80;
        static double SeasonalDiscount(double price) => price * 0.90;
        static double NoDiscount(double price) => price;

        public static double CalculateFinalPrice(double original, DiscountStrategy strategy)
            => strategy(original);

        public static void Run()
        {
            Console.WriteLine("\n--- TASK 2: Calculate & DiscountStrategy ---");

            Calculate calc = Add;
            Console.WriteLine($"Add: {calc(10, 5)}");

            calc = Subtract;
            Console.WriteLine($"Subtract: {calc(10, 5)}");

            double price = 1000;

            Console.WriteLine($"Festival Discount: {CalculateFinalPrice(price, FestivalDiscount)}");
            Console.WriteLine($"Seasonal Discount: {CalculateFinalPrice(price, SeasonalDiscount)}");
            Console.WriteLine($"No Discount: {CalculateFinalPrice(price, NoDiscount)}");

            // Lambda for 30% discount
            Console.WriteLine($"Lambda 30% Discount: {CalculateFinalPrice(price, p => p * 0.70)}");
        }
    }
}
