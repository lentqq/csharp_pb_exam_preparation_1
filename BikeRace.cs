using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            int juniorNumCyclist = int.Parse(Console.ReadLine());
            int seniorNumCyclist = int.Parse(Console.ReadLine());
            string kindRoute = Console.ReadLine().ToLower();
            double sum = 0.00;

            if (kindRoute == "trail")
            {
                sum = juniorNumCyclist * 5.50 + seniorNumCyclist * 7.00;
            }
            else if (kindRoute == "cross-country")
            {
                if ((juniorNumCyclist + seniorNumCyclist) >= 50)
                {
                    double feeJunior = 8.00 - 8.00 * 0.25;
                    double feeSenior = 9.50 - 9.50 * 0.25;
                    sum = juniorNumCyclist * feeJunior + seniorNumCyclist * feeSenior;
                }
                else
                {
                    sum = juniorNumCyclist * 8.00 + seniorNumCyclist * 9.50;

                }
            }
            else if (kindRoute == "downhill")
            {
                sum = juniorNumCyclist * 12.25 + seniorNumCyclist * 13.75;
            }
            else if (kindRoute == "road")
            {
                sum = juniorNumCyclist * 20.00 + seniorNumCyclist * 21.50;
            }
            double costs = sum * 0.05;
            double netSum = sum - costs;

            Console.WriteLine($"{netSum:f2}");
        }
    }
}
