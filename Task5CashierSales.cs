using System;
using System.Collections.Generic;
using System.Linq;

namespace Week6Workshop
{
    public class CashierSales
    {
        public string Name { get; set; }
        public double Sales { get; set; }
    }

    public class Applicant
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Music
    {
        public string Title { get; set; }
        public int DurationSec { get; set; }
    }

    public class Task5CashierSales
    {
        public static void Run()
        {
            Console.WriteLine("\n--- TASK 5: Cashier Sales ---");

            var sales = new List<CashierSales>
            {
                new CashierSales{Name="A", Sales=2000},
                new CashierSales{Name="B", Sales=3500},
                new CashierSales{Name="C", Sales=1500}
            };

            Console.WriteLine($"Total Cashiers: {sales.Count}");
            Console.WriteLine($"Total Sales: {sales.Sum(s => s.Sales)}");
            Console.WriteLine($"Highest: {sales.Max(s => s.Sales)}");
            Console.WriteLine($"Lowest: {sales.Min(s => s.Sales)}");
            Console.WriteLine($"Average: {sales.Average(s => s.Sales)}");

            var applicants = new List<Applicant>
            {
                new Applicant{Name="Ram", Age=17},
                new Applicant{Name="Sita", Age=19}
            };

            Console.WriteLine("Any under 18? " + applicants.Any(a => a.Age < 18));
            Console.WriteLine("All above 16? " + applicants.All(a => a.Age > 16));

            var songs = new List<Music>
            {
                new Music{Title="Song A", DurationSec=150},
                new Music{Title="Song B", DurationSec=300},
                new Music{Title="Song C", DurationSec=500}
            };

            Console.WriteLine("First: " + songs.First().Title);
            Console.WriteLine("Last: " + songs.Last().Title);
            Console.WriteLine("First > 4 min: " + songs.First(s => s.DurationSec > 240).Title);

            var safe = songs.FirstOrDefault(s => s.DurationSec > 600);
            Console.WriteLine("First > 10 min: " + (safe?.Title ?? "Not found"));
        }
    }
}
