using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double wage = double.Parse(Console.ReadLine());
            double USD = double.Parse(Console.ReadLine());

            double monthSalary = days * wage;
            double yearIncome = 12 * monthSalary + 2.5 * monthSalary;
            double netIncome = (yearIncome - 0.25 * yearIncome) * USD;
            double averageProfitOfDay = netIncome / 365;

            Console.WriteLine($"{(averageProfitOfDay):f2}");

        }
    }
}
