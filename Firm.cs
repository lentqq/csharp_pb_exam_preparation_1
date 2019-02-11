using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int employees = int.Parse(Console.ReadLine());

            double hoursForWork = (days - days * 0.1) * 8;
            double overTime = employees * (2 * days);
            double totalHours = Math.Floor(hoursForWork + overTime);

            if (totalHours > neededHours)
            {
                Console.WriteLine($"Yes!{totalHours - neededHours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{neededHours - totalHours} hours needed.");
            }
        }
    }
}
