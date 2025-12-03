using System;

namespace Week6Workshop
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width) =>
            (Length, Width) = (length, width);

        public double Area => Length * Width;
        public double Perimeter() => 2 * (Length + Width);
    }

    public class Task1Rectangle
    {
        public static void Run()
        {
            Console.WriteLine("\n--- TASK 1: Rectangle ---");

            var r = new Rectangle(10, 5);
            Console.WriteLine($"Area: {r.Area}");
            Console.WriteLine($"Perimeter: {r.Perimeter()}");
        }
    }
}
