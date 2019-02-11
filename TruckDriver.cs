using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            double kmOfMonth = double.Parse(Console.ReadLine());
            double sumForKm = 1.00;

            if (kmOfMonth <= 5000)
            {
                switch (season)
                {
                    case "spring":
                    case "autumn": sumForKm = 0.75; break;
                    case "summer": sumForKm = 0.90; break;
                    case "winter": sumForKm = 1.05; break;
                }
            }
            else if (kmOfMonth > 5000 && kmOfMonth <= 10000)
            {
                switch (season)
                {
                    case "spring":
                    case "autumn": sumForKm = 0.95; break;
                    case "summer": sumForKm = 1.10; break;
                    case "winter": sumForKm = 1.25; break;
                }
            }
            else if (kmOfMonth > 10000 && kmOfMonth <= 20000)
            {
                sumForKm = 1.45;
            }
            double salary = kmOfMonth * sumForKm * 4.00;
            double netSalary = salary - salary * 0.10;
            Console.WriteLine($"{netSalary:f2}");
        }
    }
}