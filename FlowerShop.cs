using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            int magnoliiy = int.Parse(Console.ReadLine());
            int zumbuly = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int cactusy = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double magnoliiyPrice = 3.25;
            double zumbulyPrice = 4.00;
            double rosePrice = 3.50;
            double cactusyPrice = 8.00;

            double sumOrder = magnoliiy * magnoliiyPrice + zumbuly * zumbulyPrice +
                rose * rosePrice + cactusy * cactusyPrice;
            double taxes = sumOrder * 0.05;
            double profit = sumOrder - taxes;

            if (profit > giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(profit - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - profit)} leva.");
            }
        }
    }
}
