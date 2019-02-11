using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.БлаготворителнаКампания
{
    class БлаготворителнаКампания
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());          
            int numConfectioner = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double dailySumCakes = cakes * 45;
            double dailySumWaffles = waffles * 5.80;
            double dailySumPancakes = pancakes * 3.20;
            double totalDailySum = (dailySumCakes + dailySumWaffles + dailySumPancakes) * numConfectioner;
            double totalcompanySum = totalDailySum * numDays;
            double costs = 1/8.0 * totalcompanySum;
            double netSum = totalcompanySum -costs;
            Console.WriteLine($"{netSum:f2}");
        }
    }
}
