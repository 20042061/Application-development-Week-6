using System;
using System.Collections.Generic;
using System.Linq;

namespace Week6Workshop
{
    public class Tour
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDay { get; set; }
        public bool IsInternational { get; set; }
    }

    public class Task6TourBookings
    {
        public static void Run()
        {
            Console.WriteLine("\n--- TASK 6: Tour Bookings ---");

            var tours = new List<Tour>
            {
                new Tour{CustomerName="A", Destination="Japan", Price=20000, DurationInDay=5, IsInternational=true},
                new Tour{CustomerName="B", Destination="Pokhara", Price=8000, DurationInDay=3, IsInternational=false},
                new Tour{CustomerName="C", Destination="Thailand", Price=15000, DurationInDay=6, IsInternational=true}
            };

            var filtered = tours.Where(t => t.Price > 10000 && t.DurationInDay > 4);

            var transformed = filtered.Select(t => new
            {
                t.CustomerName,
                t.Destination,
                Category = t.IsInternational ? "International" : "Domestic",
                t.Price
            });

            var sorted = transformed
                .OrderBy(t => t.Category)
                .ThenBy(t => t.Price);

            foreach (var t in sorted)
            {
                Console.WriteLine($"{t.CustomerName} | {t.Destination} | {t.Category} | Rs. {t.Price}");
            }
        }
    }
}
