using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double kgOfSquareMeter = double.Parse(Console.ReadLine());
            double skrapped = double.Parse(Console.ReadLine());

            double quantityGrape = area * kgOfSquareMeter;
            double netQuantityGrape = quantityGrape - skrapped;
            double quantityForRakia = netQuantityGrape * 0.45;
            double quantityRakia = quantityForRakia / 7.5;
            double profitFromRakia = quantityRakia * 9.8;
            double quantityGrapeForSale = netQuantityGrape * 0.55;
            double profitFromGrape = quantityGrapeForSale * 1.50;

            Console.WriteLine($"{profitFromRakia:f2}");
            Console.WriteLine($"{profitFromGrape:f2}");
        }
    }
}
