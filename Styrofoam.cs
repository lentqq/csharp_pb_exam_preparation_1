using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            double areaOfHouse = double.Parse(Console.ReadLine());
            int numWindows = int.Parse(Console.ReadLine());
            double squareMeterStyrofoamInPackage = double.Parse(Console.ReadLine());
            double priceOfPackageStyrofoam = double.Parse(Console.ReadLine());

            double windowArea = 2.4;
            double areaOfHouseWithoutWindows = areaOfHouse - (numWindows * windowArea);
            double netAreaOfHouse = areaOfHouseWithoutWindows + areaOfHouseWithoutWindows * 0.10;
            double neededPackageStyrofoam = Math.Ceiling(netAreaOfHouse / squareMeterStyrofoamInPackage);
            double spentMoneyForStyrofoam = neededPackageStyrofoam * priceOfPackageStyrofoam;

            if (spentMoneyForStyrofoam < buget)
            {
                Console.WriteLine($"Spent: {spentMoneyForStyrofoam:f2}");
                Console.WriteLine($"Left: {buget - spentMoneyForStyrofoam:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {spentMoneyForStyrofoam - buget:f2}");
            }
        }
    }
}
