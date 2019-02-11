using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TailoringWorkshop
{
    class TailoringWorkshop
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double lengthTable = double.Parse(Console.ReadLine());
            double withTable = double.Parse(Console.ReadLine());
            double areaTableCloths = tables * (lengthTable + 0.6) * (withTable + 0.6);
            double areaTableCover = tables * Math.Pow((lengthTable / 2), 2);
            double totalPriceUSD = areaTableCloths * 7.00 + areaTableCover * 9.00;
            double totalPriceBGN = totalPriceUSD * 1.85;

            Console.WriteLine($"{(totalPriceUSD):f2} USD");
            Console.WriteLine($"{(totalPriceBGN):f2} BGN");
            //Console.WriteLine("{0:0.00} USD",totalPriceUSD);
            //Console.WriteLine("{0:0.00} BGN",totalPriceBGN);
        }
    }
}
