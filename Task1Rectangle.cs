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
            Console.WriteLine("\n--- TASK 1: Rectangle ---\n");

            var rectangle = new Rectangle(10, 5);

            Console.WriteLine("Rectangle Details:");
            Console.WriteLine($"Length   : {rectangle.Length}");
            Console.WriteLine($"Width    : {rectangle.Width}");
            Console.WriteLine($"Area     : {rectangle.Area}");
            Console.WriteLine($"Perimeter: {rectangle.Perimeter()}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
