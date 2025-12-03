using System;
using System.Collections.Generic;
using System.Linq;

namespace Week6Workshop
{
    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
    }

    public class Task4Book
    {
        public static void Run()
        {
            Console.WriteLine("\n--- TASK 4: Book ---\n");

            // Squared numbers
            var nums = new List<int> { 1, 2, 3, 4, 5 };
            var squared = nums.Select(n => n * n);
            Console.WriteLine("Squared Numbers:");
            Console.WriteLine(string.Join(", ", squared));
            Console.WriteLine(new string('-', 40));

            // Premium books
            var books = new List<Book>
            {
                new Book { Title = "Ragnarok", Price = 1500 },
                new Book { Title = "Tom Sawyer", Price = 500 }
            };

            var premium = books.Where(b => b.Price > 1000);
            Console.WriteLine("Premium Books (Price > 1000):");
            foreach (var b in premium)
                Console.WriteLine($"- {b.Title}");
            Console.WriteLine(new string('-', 40));

            // Sorted students
            var students = new List<Student>
            {
                new Student { Name = "Zara" },
                new Student { Name = "Adam" },
                new Student { Name = "John" }
            };

            var sorted = students.OrderBy(s => s.Name);
            Console.WriteLine("Students Sorted by Name:");
            foreach (var s in sorted)
                Console.WriteLine($"- {s.Name}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
